namespace terLR1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.savefileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.corrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.taskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarclassMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.methodMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.errorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exampleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.litlistMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.codeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.launchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateFileButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton1 = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.repeatButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.launchButton = new System.Windows.Forms.ToolStripButton();
            this.referenceButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.corrMenu,
            this.textMenu,
            this.launchMenu,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createfileMenu,
            this.openMenu,
            this.savefileMenu,
            this.saveasMenu,
            this.exitfileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // createfileMenu
            // 
            this.createfileMenu.Name = "createfileMenu";
            this.createfileMenu.Size = new System.Drawing.Size(154, 22);
            this.createfileMenu.Text = "Создать";
            this.createfileMenu.Click += new System.EventHandler(this.createfileMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(154, 22);
            this.openMenu.Text = "Открыть";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // savefileMenu
            // 
            this.savefileMenu.Name = "savefileMenu";
            this.savefileMenu.Size = new System.Drawing.Size(154, 22);
            this.savefileMenu.Text = "Сохранить";
            this.savefileMenu.Click += new System.EventHandler(this.savefileMenu_Click);
            // 
            // saveasMenu
            // 
            this.saveasMenu.Name = "saveasMenu";
            this.saveasMenu.Size = new System.Drawing.Size(154, 22);
            this.saveasMenu.Text = "Сохранить как";
            this.saveasMenu.Click += new System.EventHandler(this.saveasMenu_Click);
            // 
            // exitfileMenu
            // 
            this.exitfileMenu.Name = "exitfileMenu";
            this.exitfileMenu.Size = new System.Drawing.Size(154, 22);
            this.exitfileMenu.Text = "Выход";
            this.exitfileMenu.Click += new System.EventHandler(this.exitfileMenu_Click);
            // 
            // corrMenu
            // 
            this.corrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelMenu,
            this.repeatMenu,
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.deleteMenu,
            this.chooseallMenu});
            this.corrMenu.Name = "corrMenu";
            this.corrMenu.Size = new System.Drawing.Size(59, 20);
            this.corrMenu.Text = "Правка";
            // 
            // cancelMenu
            // 
            this.cancelMenu.Name = "cancelMenu";
            this.cancelMenu.Size = new System.Drawing.Size(180, 22);
            this.cancelMenu.Text = "Отменить";
            this.cancelMenu.Click += new System.EventHandler(this.cancelMenu_Click);
            // 
            // repeatMenu
            // 
            this.repeatMenu.Name = "repeatMenu";
            this.repeatMenu.Size = new System.Drawing.Size(180, 22);
            this.repeatMenu.Text = "Повторить";
            this.repeatMenu.Click += new System.EventHandler(this.repeatMenu_Click);
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.Size = new System.Drawing.Size(180, 22);
            this.cutMenu.Text = "Вырезать";
            this.cutMenu.Click += new System.EventHandler(this.cutMenu_Click);
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(180, 22);
            this.copyMenu.Text = "Копировать";
            this.copyMenu.Click += new System.EventHandler(this.copyMenu_Click);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(180, 22);
            this.pasteMenu.Text = "Вставить";
            this.pasteMenu.Click += new System.EventHandler(this.pasteMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(180, 22);
            this.deleteMenu.Text = "Удалить";
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // chooseallMenu
            // 
            this.chooseallMenu.Name = "chooseallMenu";
            this.chooseallMenu.Size = new System.Drawing.Size(180, 22);
            this.chooseallMenu.Text = "Выделить все";
            this.chooseallMenu.Click += new System.EventHandler(this.chooseallMenu_Click);
            // 
            // textMenu
            // 
            this.textMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskMenu,
            this.grammarMenu,
            this.grammarclassMenu,
            this.methodMenu,
            this.errorMenu,
            this.exampleMenu,
            this.litlistMenu,
            this.codeMenu});
            this.textMenu.Name = "textMenu";
            this.textMenu.Size = new System.Drawing.Size(48, 20);
            this.textMenu.Text = "Текст";
            // 
            // taskMenu
            // 
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(288, 22);
            this.taskMenu.Text = "Постановка задачи";
            // 
            // grammarMenu
            // 
            this.grammarMenu.Name = "grammarMenu";
            this.grammarMenu.Size = new System.Drawing.Size(288, 22);
            this.grammarMenu.Text = "Грамматика";
            // 
            // grammarclassMenu
            // 
            this.grammarclassMenu.Name = "grammarclassMenu";
            this.grammarclassMenu.Size = new System.Drawing.Size(288, 22);
            this.grammarclassMenu.Text = "Классификация грамматики";
            // 
            // methodMenu
            // 
            this.methodMenu.Name = "methodMenu";
            this.methodMenu.Size = new System.Drawing.Size(288, 22);
            this.methodMenu.Text = "Метод анализа";
            // 
            // errorMenu
            // 
            this.errorMenu.Name = "errorMenu";
            this.errorMenu.Size = new System.Drawing.Size(288, 22);
            this.errorMenu.Text = "Диагностика и нейтрализация ошибок";
            // 
            // exampleMenu
            // 
            this.exampleMenu.Name = "exampleMenu";
            this.exampleMenu.Size = new System.Drawing.Size(288, 22);
            this.exampleMenu.Text = "Тестовый пример";
            // 
            // litlistMenu
            // 
            this.litlistMenu.Name = "litlistMenu";
            this.litlistMenu.Size = new System.Drawing.Size(288, 22);
            this.litlistMenu.Text = "Список литературы";
            // 
            // codeMenu
            // 
            this.codeMenu.Name = "codeMenu";
            this.codeMenu.Size = new System.Drawing.Size(288, 22);
            this.codeMenu.Text = "Исходный код программы";
            // 
            // launchMenu
            // 
            this.launchMenu.Name = "launchMenu";
            this.launchMenu.Size = new System.Drawing.Size(46, 20);
            this.launchMenu.Text = "Пуск";
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceMenu,
            this.aboutProg});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(65, 20);
            this.aboutMenu.Text = "Справка";
            // 
            // referenceMenu
            // 
            this.referenceMenu.Name = "referenceMenu";
            this.referenceMenu.Size = new System.Drawing.Size(156, 22);
            this.referenceMenu.Text = "Вызов справки";
            this.referenceMenu.Click += new System.EventHandler(this.referenceMenu_Click);
            // 
            // aboutProg
            // 
            this.aboutProg.Name = "aboutProg";
            this.aboutProg.Size = new System.Drawing.Size(156, 22);
            this.aboutProg.Text = "О программе";
            this.aboutProg.Click += new System.EventHandler(this.aboutProg_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileButton,
            this.OpenFileButton,
            this.saveButton1,
            this.cancelButton,
            this.repeatButton,
            this.copyButton,
            this.cutButton,
            this.pasteButton,
            this.launchButton,
            this.referenceButton,
            this.aboutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateFileButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateFileButton.Image")));
            this.CreateFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(23, 22);
            this.CreateFileButton.Text = "Создать файл";
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFileButton.Text = "Открыть файл";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveButton1.Image")));
            this.saveButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(23, 22);
            this.saveButton1.Text = "Сохранить";
            this.saveButton1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(23, 22);
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatButton.Image = ((System.Drawing.Image)(resources.GetObject("repeatButton.Image")));
            this.repeatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(23, 22);
            this.repeatButton.Text = "Повторить";
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(23, 22);
            this.copyButton.Text = "Копировать";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(23, 22);
            this.cutButton.Text = "Вырезать";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(23, 22);
            this.pasteButton.Text = "Вставить";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.launchButton.Image = ((System.Drawing.Image)(resources.GetObject("launchButton.Image")));
            this.launchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(23, 22);
            this.launchButton.Text = "Пуск";
            // 
            // referenceButton
            // 
            this.referenceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.referenceButton.Image = ((System.Drawing.Image)(resources.GetObject("referenceButton.Image")));
            this.referenceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(23, 22);
            this.referenceButton.Text = "Вызов справки";
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(23, 22);
            this.aboutButton.Text = "О программе";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(12, 52);
            this.inputBox.Name = "inputBox";
            this.inputBox.ShowSelectionMargin = true;
            this.inputBox.Size = new System.Drawing.Size(776, 180);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(12, 238);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ShowSelectionMargin = true;
            this.outputBox.Size = new System.Drawing.Size(776, 191);
            this.outputBox.TabIndex = 3;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Компилятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem createfileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem savefileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveasMenu;
        private System.Windows.Forms.ToolStripMenuItem exitfileMenu;
        private System.Windows.Forms.ToolStripMenuItem corrMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelMenu;
        private System.Windows.Forms.ToolStripMenuItem repeatMenu;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem chooseallMenu;
        private System.Windows.Forms.ToolStripMenuItem textMenu;
        private System.Windows.Forms.ToolStripMenuItem taskMenu;
        private System.Windows.Forms.ToolStripMenuItem grammarMenu;
        private System.Windows.Forms.ToolStripMenuItem grammarclassMenu;
        private System.Windows.Forms.ToolStripMenuItem methodMenu;
        private System.Windows.Forms.ToolStripMenuItem errorMenu;
        private System.Windows.Forms.ToolStripMenuItem exampleMenu;
        private System.Windows.Forms.ToolStripMenuItem litlistMenu;
        private System.Windows.Forms.ToolStripMenuItem codeMenu;
        private System.Windows.Forms.ToolStripMenuItem launchMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem referenceMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutProg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton1;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton CreateFileButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton repeatButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripButton launchButton;
        private System.Windows.Forms.ToolStripButton referenceButton;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

