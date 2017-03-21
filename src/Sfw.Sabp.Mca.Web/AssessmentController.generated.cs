// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Sfw.Sabp.Mca.Web.Controllers
{
    public partial class AssessmentController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AssessmentController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CreatePdf()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreatePdf);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Create()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Restart()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Restart);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestartNo()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartNo);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestartAssessment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartAssessment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestartStage()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartStage);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestartStartAssessment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartStartAssessment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestartFromBreak()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartFromBreak);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddCompletionDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddCompletionDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Complete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Complete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AssessmentController Actions { get { return MVC.Assessment; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Assessment";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Assessment";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string CreatePdf = "CreatePdf";
            public readonly string Create = "Create";
            public readonly string Restart = "Restart";
            public readonly string RestartNo = "RestartNo";
            public readonly string RestartAssessment = "RestartAssessment";
            public readonly string RestartStage = "RestartStage";
            public readonly string RestartStartAssessment = "RestartStartAssessment";
            public readonly string RestartFromBreak = "RestartFromBreak";
            public readonly string AddCompletionDetails = "AddCompletionDetails";
            public readonly string Complete = "Complete";
            public readonly string Edit = "Edit";
            public readonly string FeedBack = "FeedBack";
            public readonly string Copyright = "Copyright";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string CreatePdf = "CreatePdf";
            public const string Create = "Create";
            public const string Restart = "Restart";
            public const string RestartNo = "RestartNo";
            public const string RestartAssessment = "RestartAssessment";
            public const string RestartStage = "RestartStage";
            public const string RestartStartAssessment = "RestartStartAssessment";
            public const string RestartFromBreak = "RestartFromBreak";
            public const string AddCompletionDetails = "AddCompletionDetails";
            public const string Complete = "Complete";
            public const string Edit = "Edit";
            public const string FeedBack = "FeedBack";
            public const string Copyright = "Copyright";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_CreatePdf s_params_CreatePdf = new ActionParamsClass_CreatePdf();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreatePdf CreatePdfParams { get { return s_params_CreatePdf; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreatePdf
        {
            public readonly string id = "id";
            public readonly string clinicalSystemId = "clinicalSystemId";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string id = "id";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Restart s_params_Restart = new ActionParamsClass_Restart();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Restart RestartParams { get { return s_params_Restart; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Restart
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_RestartNo s_params_RestartNo = new ActionParamsClass_RestartNo();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestartNo RestartNoParams { get { return s_params_RestartNo; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestartNo
        {
            public readonly string model = "model";
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ActionParamsClass_RestartAssessment s_params_RestartAssessment = new ActionParamsClass_RestartAssessment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestartAssessment RestartAssessmentParams { get { return s_params_RestartAssessment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestartAssessment
        {
            public readonly string model = "model";
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ActionParamsClass_RestartStage s_params_RestartStage = new ActionParamsClass_RestartStage();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestartStage RestartStageParams { get { return s_params_RestartStage; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestartStage
        {
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ActionParamsClass_RestartStartAssessment s_params_RestartStartAssessment = new ActionParamsClass_RestartStartAssessment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestartStartAssessment RestartStartAssessmentParams { get { return s_params_RestartStartAssessment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestartStartAssessment
        {
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ActionParamsClass_RestartFromBreak s_params_RestartFromBreak = new ActionParamsClass_RestartFromBreak();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestartFromBreak RestartFromBreakParams { get { return s_params_RestartFromBreak; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestartFromBreak
        {
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ActionParamsClass_AddCompletionDetails s_params_AddCompletionDetails = new ActionParamsClass_AddCompletionDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddCompletionDetails AddCompletionDetailsParams { get { return s_params_AddCompletionDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddCompletionDetails
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Complete s_params_Complete = new ActionParamsClass_Complete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Complete CompleteParams { get { return s_params_Complete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Complete
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = "id";
            public readonly string model = "model";
            public readonly string assessmentId = "assessmentId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _DetailsPartial = "_DetailsPartial";
                public readonly string _FeedBackText = "_FeedBackText";
                public readonly string Complete = "Complete";
                public readonly string Create = "Create";
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
                public readonly string Restart = "Restart";
                public readonly string Terminated = "Terminated";
            }
            public readonly string _DetailsPartial = "~/Views/Assessment/_DetailsPartial.cshtml";
            public readonly string _FeedBackText = "~/Views/Assessment/_FeedBackText.cshtml";
            public readonly string Complete = "~/Views/Assessment/Complete.cshtml";
            public readonly string Create = "~/Views/Assessment/Create.cshtml";
            public readonly string Edit = "~/Views/Assessment/Edit.cshtml";
            public readonly string Index = "~/Views/Assessment/Index.cshtml";
            public readonly string Restart = "~/Views/Assessment/Restart.cshtml";
            public readonly string Terminated = "~/Views/Assessment/Terminated.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AssessmentController : Sfw.Sabp.Mca.Web.Controllers.AssessmentController
    {
        public T4MVC_AssessmentController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            IndexOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CreatePdfOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id, string clinicalSystemId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreatePdf(System.Guid id, string clinicalSystemId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreatePdf);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "clinicalSystemId", clinicalSystemId);
            CreatePdfOverride(callInfo, id, clinicalSystemId);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CreateOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            CreateOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void RestartOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Restart(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Restart);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            RestartOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void RestartNoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestartNo(Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartNo);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            RestartNoOverride(callInfo, model, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void RestartAssessmentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestartAssessment(Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartAssessment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            RestartAssessmentOverride(callInfo, model, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void RestartStageOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestartStage(System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartStage);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            RestartStageOverride(callInfo, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void RestartStartAssessmentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestartStartAssessment(System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartStartAssessment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            RestartStartAssessmentOverride(callInfo, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void RestartFromBreakOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestartFromBreak(System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestartFromBreak);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            RestartFromBreakOverride(callInfo, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void AddCompletionDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Sfw.Sabp.Mca.Web.ViewModels.TerminatedViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddCompletionDetails(Sfw.Sabp.Mca.Web.ViewModels.TerminatedViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddCompletionDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddCompletionDetailsOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void CompleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Complete(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Complete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CompleteOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(Sfw.Sabp.Mca.Web.ViewModels.AssessmentViewModel model, System.Guid assessmentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "assessmentId", assessmentId);
            EditOverride(callInfo, model, assessmentId);
            return callInfo;
        }

        [NonAction]
        partial void FeedBackOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult FeedBack()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FeedBack);
            FeedBackOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CopyrightOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Copyright()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Copyright);
            CopyrightOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108