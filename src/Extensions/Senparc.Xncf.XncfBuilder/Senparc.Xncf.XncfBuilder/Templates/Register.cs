﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Senparc.Xncf.XncfBuilder.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class Register : RegisterBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing Senparc.Ncf.XncfBase;\r\n");
            
            #line 9 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 if(UseFunction) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 10 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 10 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(".Functions;\r\n");
            
            #line 11 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 } 
            
            #line default
            #line hidden
            
            #line 12 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 if(UseDatabase) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 13 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 13 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(".Models.DatabaseModel;\r\nusing Senparc.Ncf.Core.Enums;\r\nusing Senparc.Ncf.Core.Mod" +
                    "els;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.Extensi" +
                    "ons.DependencyInjection;\r\nusing Senparc.Ncf.Database;\r\n");
            
            #line 20 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 } 
            
            #line default
            #line hidden
            
            #line 21 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 if(UseSample) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 22 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 22 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(".Services;\r\nusing ");
            
            #line 23 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 23 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(".Models.DatabaseModel.Dto;\r\n");
            
            #line 24 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 26 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 26 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [XncfRegister]\r\n    public partial class Register : XncfRegisterBase, IX" +
                    "ncfRegister\r\n    {\r\n        #region IXncfRegister 接口\r\n\r\n        public override " +
                    "string Name => \"");
            
            #line 33 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OrgName));
            
            #line default
            #line hidden
            this.Write(".Xncf.");
            
            #line 33 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public override string Uid => \"");
            
            #line 35 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Uid));
            
            #line default
            #line hidden
            this.Write("\";//必须确保全局唯一，生成后必须固定，已自动生成，也可自行修改\r\n\r\n        public override string Version => \"");
            
            #line 37 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Version));
            
            #line default
            #line hidden
            this.Write("\";//必须填写版本号\r\n\r\n        public override string MenuName => \"");
            
            #line 39 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MenuName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public override string Icon => \"");
            
            #line 41 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Icon));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public override string Description => \"");
            
            #line 43 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Description));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public override IList<Type> Functions => new Type[] { ");
            
            #line 45 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FunctionTypes));
            
            #line default
            #line hidden
            this.Write(" };\r\n\r\n\r\n        ");
            
            #line 48 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 if(UseDatabase) { 
            
            #line default
            #line hidden
            this.Write(@"        public override async Task InstallOrUpdateAsync(IServiceProvider serviceProvider, InstallOrUpdate installOrUpdate)
        {
            //安装或升级版本时更新数据库
            await base.MigrateDatabaseAsync(serviceProvider);

            //根据安装或更新不同条件执行逻辑
            switch (installOrUpdate)
            {
                case InstallOrUpdate.Install:
                    //新安装
                    ");
            
            #line 59 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 if(UseSample) { 
            
            #line default
            #line hidden
            this.Write(@"                    #region 初始化数据库数据
                    var colorService = serviceProvider.GetService<ColorService>();
                    var color = colorService.GetObject(z => true);
                    if (color == null)//如果是纯第一次安装，理论上不会有残留数据
                    {
                        ColorDto colorDto = await colorService.CreateNewColor().ConfigureAwait(false);//创建默认颜色
                    }
                    #endregion
                    ");
            
            #line 68 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 }
            
            #line default
            #line hidden
            this.Write(@"                    break;
                case InstallOrUpdate.Update:
                    //更新
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override async Task UninstallAsync(IServiceProvider serviceProvider, Func<Task> unsinstallFunc)
        {
            #region 删除数据库（演示）

            var mySenparcEntitiesType = this.TryGetXncfDatabaseDbContextType;
            ");
            
            #line 83 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write("SenparcEntities mySenparcEntities = serviceProvider.GetService(mySenparcEntitiesT" +
                    "ype) as ");
            
            #line 83 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(XncfName));
            
            #line default
            #line hidden
            this.Write(@"SenparcEntities;

            //指定需要删除的数据实体

            //注意：这里作为演示，在卸载模块的时候删除了所有本模块创建的表，实际操作过程中，请谨慎操作，并且按照删除顺序对实体进行排序！
            var dropTableKeys = EntitySetKeys.GetEntitySetInfo(this.TryGetXncfDatabaseDbContextType).Keys.ToArray();
            await base.DropTablesAsync(serviceProvider, mySenparcEntities, dropTableKeys);

            #endregion

            await unsinstallFunc().ConfigureAwait(false);
        }
        ");
            
            #line 95 "E:\Senparc项目\NeuCharFramework\NcfPackageSources\src\Extensions\Senparc.Xncf.XncfBuilder\Senparc.Xncf.XncfBuilder\Templates\Register.tt"
 }
            
            #line default
            #line hidden
            this.Write("\r\n        #endregion\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class RegisterBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
