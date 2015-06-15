using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace SimpleViewModel.Core
{
    public abstract class BaseViewModel
    {
        private BindingSource _BindingSource = new BindingSource();

        public BaseViewModel()
        {
            _BindingSource.DataSource = GetType();
            _BindingSource.Add(this);
        }

        public void Bind(string pPropertyName, Control pControl, string pControlPropertyName = "Text")
        {
            pControl.DataBindings.Add(pControlPropertyName, _BindingSource, pPropertyName);
        }
    }

    public static class ViewModelExtension
    {
        public static void BindTo<TModel, TControl, TPropertyType>(this TModel pModel, Expression<Func<TModel, TPropertyType>> pExprVmProperty, TControl pControl, 
            Expression<Func<TControl, TPropertyType>> pExprControlProperty, Action<TControl> pActionInit=null)
            where TModel : BaseViewModel
            where TControl : Control
        {
            string lPropertyName = ExpressionHelper.GetExpressionText(pExprVmProperty);
            string lCtrlPropertyName = ExpressionHelper.GetExpressionText(pExprControlProperty);

            if (pActionInit != null)
                pActionInit(pControl);

            pModel.Bind(lPropertyName, pControl, lCtrlPropertyName);
        }
    }
}
