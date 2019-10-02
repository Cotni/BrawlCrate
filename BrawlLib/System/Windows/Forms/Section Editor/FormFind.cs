using Be.Windows.Forms;
using System.ComponentModel;

namespace System.Windows.Forms
{
    /// <summary>
    /// Summary description for FormFind.
    /// </summary>
    public class FormFind : Form
    {
        private HexBox hexFind;
        private TextBox txtFind;
        private RadioButton rbString;
        private RadioButton rbHex;
        private Label label1;
        private Button btnOK;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Label lblPercent;
        private Label lblFinding;
        private CheckBox chkMatchCase;
        private Timer timerPercent;
        private Timer timer;
        private FlowLayoutPanel flowLayoutPanel1;
        private IContainer components;
        private readonly SectionEditor _mainWindow;

        public FormFind(SectionEditor mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            HexBox = _mainWindow.hexBox1;
            FindOptions = _mainWindow._findOptions;
            rbString.CheckedChanged += rb_CheckedChanged;
            rbHex.CheckedChanged += rb_CheckedChanged;
        }

        private void ByteProvider_Changed(object sender, EventArgs e)
        {
            ValidateFind();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormFind));
            txtFind = new TextBox();
            rbString = new RadioButton();
            rbHex = new RadioButton();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            lblPercent = new Label();
            lblFinding = new Label();
            chkMatchCase = new CheckBox();
            timerPercent = new Timer(components);
            timer = new Timer(components);
            hexFind = new HexBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFind
            // 
            resources.ApplyResources(txtFind, "txtFind");
            txtFind.Name = "txtFind";
            txtFind.TextChanged += txtString_TextChanged;
            // 
            // rbString
            // 
            resources.ApplyResources(rbString, "rbString");
            rbString.Checked = true;
            rbString.Name = "rbString";
            rbString.TabStop = true;
            // 
            // rbHex
            // 
            resources.ApplyResources(rbHex, "rbHex");
            rbHex.Name = "rbHex";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Drawing.Color.Blue;
            label1.Name = "label1";
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // lblPercent
            // 
            resources.ApplyResources(lblPercent, "lblPercent");
            lblPercent.Name = "lblPercent";
            // 
            // lblFinding
            // 
            resources.ApplyResources(lblFinding, "lblFinding");
            lblFinding.ForeColor = Drawing.Color.Blue;
            lblFinding.Name = "lblFinding";
            // 
            // chkMatchCase
            // 
            resources.ApplyResources(chkMatchCase, "chkMatchCase");
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // timerPercent
            // 
            timerPercent.Tick += timerPercent_Tick;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            // 
            // hexFind
            // 
            resources.ApplyResources(hexFind, "hexFind");
            // 
            // 
            // 
            //this.hexFind.BuiltInContextMenu.CopyMenuItemImage = global::Be.HexEditor.images.CopyHS;
            //this.hexFind.BuiltInContextMenu.CopyMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CopyMenuItemText");
            //this.hexFind.BuiltInContextMenu.CutMenuItemImage = global::Be.HexEditor.images.CutHS;
            //this.hexFind.BuiltInContextMenu.CutMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.CutMenuItemText");
            //this.hexFind.BuiltInContextMenu.PasteMenuItemImage = global::Be.HexEditor.images.PasteHS;
            //this.hexFind.BuiltInContextMenu.PasteMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.PasteMenuItemText");
            //this.hexFind.BuiltInContextMenu.SelectAllMenuItemText = resources.GetString("hexFind.BuiltInContextMenu.SelectAllMenuItemText");
            hexFind.InfoForeColor = Drawing.Color.Empty;
            hexFind.Name = "hexFind";
            hexFind.ShadowSelectionColor = Drawing.Color.FromArgb(100, 60, 188, 255);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // FormFind
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            BackColor = Drawing.SystemColors.Control;
            CancelButton = btnCancel;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chkMatchCase);
            Controls.Add(lblPercent);
            Controls.Add(lblFinding);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(rbHex);
            Controls.Add(rbString);
            Controls.Add(txtFind);
            Controls.Add(hexFind);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFind";
            ShowIcon = false;
            ShowInTaskbar = false;
            Activated += FormFind_Activated;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FindOptions _findOptions;

        public FindOptions FindOptions
        {
            get => _findOptions;
            set
            {
                _findOptions = value;
                Reinitialize();
            }
        }

        public HexBox HexBox { get; set; }

        private void Reinitialize()
        {
            rbString.Checked = _findOptions.Type == FindType.Text;
            txtFind.Text = _findOptions.Text;
            chkMatchCase.Checked = _findOptions.MatchCase;

            rbHex.Checked = _findOptions.Type == FindType.Hex;

            if (hexFind.ByteProvider != null)
            {
                hexFind.ByteProvider.Changed -= ByteProvider_Changed;
            }

            byte[] hex = _findOptions.Hex ?? new byte[0];
            hexFind.ByteProvider = new DynamicByteProvider(hex);
            hexFind.ByteProvider.Changed += ByteProvider_Changed;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            txtFind.Enabled = rbString.Checked;
            hexFind.Enabled = !txtFind.Enabled;

            if (txtFind.Enabled)
            {
                txtFind.Focus();
            }
            else
            {
                hexFind.Focus();
            }
        }

        private void rbString_Enter(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void rbHex_Enter(object sender, EventArgs e)
        {
            hexFind.Focus();
        }

        private void FormFind_Activated(object sender, EventArgs e)
        {
            if (rbString.Checked)
            {
                txtFind.Focus();
            }
            else
            {
                hexFind.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _findOptions.MatchCase = chkMatchCase.Checked;

            DynamicByteProvider provider = hexFind.ByteProvider as DynamicByteProvider;
            _findOptions.Hex = provider.Bytes.ToArray();
            _findOptions.Text = txtFind.Text;
            _findOptions.Type = rbHex.Checked ? FindType.Hex : FindType.Text;
            _findOptions.MatchCase = chkMatchCase.Checked;
            _findOptions.IsValid = true;

            bool empty = rbHex.Checked ? _findOptions.Hex.Length == 0 : _findOptions.Text.Length == 0;
            if (empty)
            {
                return;
            }

            _mainWindow._findOptions = _findOptions;
            _mainWindow.Find(false);
            Close();
        }

        private bool _finding;

        private void UpdateUIToNormalState()
        {
            timer.Stop();
            timerPercent.Stop();
            _finding = false;
            txtFind.Enabled = chkMatchCase.Enabled = rbHex.Enabled = rbString.Enabled
                = hexFind.Enabled = btnOK.Enabled = true;
        }

        private void UpdateUIToFindingState()
        {
            _finding = true;
            timer.Start();
            timerPercent.Start();
            txtFind.Enabled = chkMatchCase.Enabled = rbHex.Enabled = rbString.Enabled
                = hexFind.Enabled = btnOK.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_finding)
            {
                HexBox.AbortFind();
            }
            else
            {
                Close();
            }
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            ValidateFind();
        }

        private void ValidateFind()
        {
            bool isValid = false;
            if (rbString.Checked && txtFind.Text.Length > 0)
            {
                isValid = true;
            }

            if (rbHex.Checked && hexFind.ByteProvider.Length > 0)
            {
                isValid = true;
            }

            btnOK.Enabled = isValid;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblFinding.Text.Length == 13)
            {
                lblFinding.Text = "";
            }

            lblFinding.Text += ".";
        }

        private void timerPercent_Tick(object sender, EventArgs e)
        {
            long pos = HexBox.CurrentFindingPosition;
            long length = HexBox.ByteProvider.Length;
            double percent = pos / (double) length * 100;

            Globalization.NumberFormatInfo nfi =
                new Globalization.CultureInfo("en-US").NumberFormat;

            string text = percent.ToString("0.00", nfi) + " %";
            lblPercent.Text = text;
        }
    }
}