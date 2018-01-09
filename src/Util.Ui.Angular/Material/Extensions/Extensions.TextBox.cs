﻿using Util.Ui.Components;
using Util.Ui.Components.Internal;
using Util.Ui.Configs;
using Util.Ui.Material.Configs;
using Util.Ui.Operations.Forms.Validations;

namespace Util.Ui.Material.Extensions {
    /// <summary>
    /// 文本框扩展
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 设置为密码框
        /// </summary>
        /// <typeparam name="TComponent">组件类型</typeparam>
        /// <param name="component">组件实例</param>
        public static TComponent Password<TComponent>( this TComponent component ) where TComponent : ITextBox {
            var option = component as IOptionConfig;
            option?.Config<Config>( config => {
                config.SetAttribute( UiConst.Type, "password" );
            } );
            return component;
        }

        /// <summary>
        /// 只能输入数字
        /// </summary>
        /// <typeparam name="TComponent">组件类型</typeparam>
        /// <param name="component">组件实例</param>
        public static TComponent Number<TComponent>( this TComponent component ) where TComponent : ITextBox {
            var option = component as IOptionConfig;
            option?.Config<Config>( config => {
                config.SetAttribute( UiConst.Type, "number" );
            } );
            return component;
        }

        /// <summary>
        /// 电子邮件验证
        /// </summary>
        /// <typeparam name="TComponent">组件类型</typeparam>
        /// <param name="component">组件实例</param>
        /// <param name="message">电子邮件验证错误消息</param>
        public static TComponent Email<TComponent>( this TComponent component,string message = null ) where TComponent : IComponent,IEmail {
            var option = component as IOptionConfig;
            option?.Config<Config>( config => {
                config.SetAttribute( UiConst.Type, "email" );
                config.SetAttribute( UiConst.EmailMessage, message );
            } );
            return component;
        }

        /// <summary>
        /// 是否显示清除按钮
        /// </summary>
        /// <typeparam name="TComponent">组件类型</typeparam>
        /// <param name="component">组件实例</param>
        /// <param name="isShow">是否显示清除按钮</param>
        public static TComponent ShowClearButton<TComponent>( this TComponent component,bool isShow ) where TComponent : ITextBox {
            var option = component as IOptionConfig;
            option?.Config<Config>( config => {
                config.SetAttribute( MaterialConst.ShowClearButton, isShow );
            } );
            return component;
        }
    }
}
