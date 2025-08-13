using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static bool IsDarkMode { get; set; } = false;

    // Light mode colors for buttons
    private static readonly Color LightButtonBackColor = Color.FromArgb(227, 234, 242);
    private static readonly Color LightButtonForeColor = Color.FromArgb(104, 120, 143);
    private static readonly Color LightButtonHoverBackColor = Color.FromArgb(11, 47, 82);
    private static readonly Color LightButtonHoverForeColor = Color.White;

    private static Dictionary<Control, (Color BackColor, Color ForeColor, FlatStyle? FlatStyle)> originalStyles
        = new Dictionary<Control, (Color, Color, FlatStyle?)>();

    public static void ApplyTheme(Form form)
    {
        Color darkBack = Color.FromArgb(30, 30, 30);
        Color darkFore = Color.White;

        // Store form original
        if (!originalStyles.ContainsKey(form))
            originalStyles[form] = (form.BackColor, form.ForeColor, null);

        if (IsDarkMode)
        {
            form.BackColor = darkBack;
            form.ForeColor = darkFore;
        }
        else
        {
            var (origBack, origFore, _) = originalStyles[form];
            form.BackColor = origBack;
            form.ForeColor = origFore;
        }

        ApplyThemeRecursive(form.Controls, darkBack, darkFore);
    }

    private static void ApplyThemeRecursive(Control.ControlCollection controls, Color darkBack, Color darkFore)
    {
        foreach (Control ctrl in controls)
        {
            if (!originalStyles.ContainsKey(ctrl))
            {
                FlatStyle? flat = ctrl is Button btn ? btn.FlatStyle : null;
                originalStyles[ctrl] = (ctrl.BackColor, ctrl.ForeColor, flat);
            }

            if (IsDarkMode)
            {
                ApplyDarkMode(ctrl, darkBack, darkFore);
            }
            else
            {
                ApplyLightMode(ctrl);
            }

            if (ctrl.HasChildren)
                ApplyThemeRecursive(ctrl.Controls, darkBack, darkFore);
        }
    }

    private static void ApplyDarkMode(Control ctrl, Color darkBack, Color darkFore)
    {
        if (ctrl is DataGridView dgv)
        {
            dgv.BackgroundColor = darkBack;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
        }
        else if (!(ctrl is CheckBox))
        {
            ctrl.BackColor = darkBack;
            ctrl.ForeColor = darkFore;
        }

        if (ctrl is Button btn)
        {
            ApplyDarkModeToButton(btn, darkBack, darkFore);
        }
    }

    private static void ApplyDarkModeToButton(Button btn, Color darkBack, Color darkFore)
    {
        btn.FlatStyle = FlatStyle.Flat;
        btn.UseVisualStyleBackColor = false;
        btn.BackColor = darkBack;
        btn.ForeColor = darkFore;

        btn.FlatAppearance.BorderColor = Color.Gray;
        btn.FlatAppearance.BorderSize = 1;
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
        btn.FlatAppearance.CheckedBackColor = darkBack;

        btn.GotFocus -= KeepDarkFocus;
        btn.LostFocus -= KeepDarkFocus;
        btn.GotFocus += KeepDarkFocus;
        btn.LostFocus += KeepDarkFocus;

        // 🔁 Universal hover handler
        btn.MouseEnter -= UniversalButton_MouseEnter;
        btn.MouseLeave -= UniversalButton_MouseLeave;
        btn.MouseEnter += UniversalButton_MouseEnter;
        btn.MouseLeave += UniversalButton_MouseLeave;
    }

    private static void ApplyLightMode(Control ctrl)
    {
        var (origBack, origFore, origFlat) = originalStyles[ctrl];
        
        if (ctrl is DataGridView dgv)
        {
            dgv.BackgroundColor = origBack;
            dgv.DefaultCellStyle.BackColor = origBack;
            dgv.DefaultCellStyle.ForeColor = origFore;
            dgv.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dgv.EnableHeadersVisualStyles = true;
        }
        else if (ctrl is Button btn)
        {
            ApplyLightModeToButton(btn, origBack, origFore, origFlat);
        }
        else
        {
            ctrl.BackColor = origBack;
            ctrl.ForeColor = origFore;
        }
    }

    private static void ApplyLightModeToButton(Button btn, Color origBack, Color origFore, FlatStyle? origFlat)
    {
        // Restore button to light mode colors
        btn.UseVisualStyleBackColor = true;
        btn.FlatStyle = origFlat ?? FlatStyle.Standard;
        btn.BackColor = LightButtonBackColor;
        btn.ForeColor = LightButtonForeColor;

        // Reset button appearance
        btn.FlatAppearance.MouseOverBackColor = LightButtonHoverBackColor;
        btn.FlatAppearance.MouseDownBackColor = LightButtonHoverBackColor;
        btn.FlatAppearance.CheckedBackColor = LightButtonBackColor;
        btn.FlatAppearance.BorderColor = SystemColors.ControlDark;

        btn.GotFocus -= KeepDarkFocus;
        btn.LostFocus -= KeepDarkFocus;

        // 🔁 Universal hover handler
        btn.MouseEnter -= UniversalButton_MouseEnter;
        btn.MouseLeave -= UniversalButton_MouseLeave;
        btn.MouseEnter += UniversalButton_MouseEnter;
        btn.MouseLeave += UniversalButton_MouseLeave;
    }

    private static void KeepDarkFocus(object sender, EventArgs e)
    {
        if (sender is Button btn && IsDarkMode)
        {
            btn.BackColor = Color.FromArgb(30, 30, 30);
        }
    }

    // 🔁 Universal Hover Logic
    private static void UniversalButton_MouseEnter(object sender, EventArgs e)
    {
        if (sender is Button btn)
            ApplyButtonHoverStyle(btn, true);
    }

    private static void UniversalButton_MouseLeave(object sender, EventArgs e)
    {
        if (sender is Button btn)
            ApplyButtonHoverStyle(btn, false);
    }

    public static void ApplyButtonHoverStyle(Button button, bool isHovering)
    {
        if (IsDarkMode)
        {
            button.BackColor = isHovering ? 
                Color.FromArgb(45, 45, 45) : 
                Color.FromArgb(30, 30, 30);
            button.ForeColor = Color.White;
        }
        else
        {
            button.BackColor = isHovering ? 
                LightButtonHoverBackColor : 
                LightButtonBackColor;
            button.ForeColor = isHovering ? 
                LightButtonHoverForeColor : 
                LightButtonForeColor;
        }
    }
}