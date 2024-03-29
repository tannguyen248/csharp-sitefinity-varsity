#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 8 "..\..\MVC\Views\CourseDetail\Index.cshtml"
    using SitefinityWebApp.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 6 "..\..\MVC\Views\CourseDetail\Index.cshtml"
    using Telerik.Sitefinity.DynamicModules.Model;
    
    #line default
    #line hidden
    
    #line 7 "..\..\MVC\Views\CourseDetail\Index.cshtml"
    using Telerik.Sitefinity.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CourseDetail/Index.cshtml")]
    public partial class _MVC_Views_CourseDetail_Index_cshtml : System.Web.Mvc.WebViewPage<CourseDetailModel>
    {

#line 33 "..\..\MVC\Views\CourseDetail\Index.cshtml"
public System.Web.WebPages.HelperResult RenderCourseOutline(List<DynamicContent> outlines) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                                                            


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<h4>Course Outline</h4>\r\n");

WriteLiteralTo(__razor_helper_writer, "<div");

WriteLiteralTo(__razor_helper_writer, " class=\"table-responsive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t<table");

WriteLiteralTo(__razor_helper_writer, " class=\"table\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th> Title </th>\r\n\t\t\t\t<th> Course Time </th>\r\n\t\t\t\t<th>" +
" Spent Time </th>\r\n\t\t\t\t<th> Status </th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");


#line 46 "..\..\MVC\Views\CourseDetail\Index.cshtml"
			

#line default
#line hidden

#line 46 "..\..\MVC\Views\CourseDetail\Index.cshtml"
             for (var i = 0; i < outlines.Count; i++) {
				var outline = outlines[i];


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");


#line 49 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, i + 1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ". ");


#line 49 "..\..\MVC\Views\CourseDetail\Index.cshtml"
    WriteTo(__razor_helper_writer, outline.GetValue("DisplayTitle"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</td>\r\n\t\t\t\t\t<td>");


#line 50 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, outline.GetValue("CourseTime"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</td>\r\n\t\t\t\t\t<td>");


#line 51 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, outline.GetValue("SpentTime"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</td>\r\n\t\t\t\t\t<td>");


#line 52 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, outline.GetValue("CourseStatus"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</td>\r\n\t\t\t\t</tr>\r\n");


#line 54 "..\..\MVC\Views\CourseDetail\Index.cshtml"
			}


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t\t</tbody>\r\n\t</table>\r\n</div>\r\n");


#line 58 "..\..\MVC\Views\CourseDetail\Index.cshtml"


#line default
#line hidden
});

#line 58 "..\..\MVC\Views\CourseDetail\Index.cshtml"
}
#line default
#line hidden

#line 60 "..\..\MVC\Views\CourseDetail\Index.cshtml"
public System.Web.WebPages.HelperResult RenderCourseDetail(DynamicContent courseDetail)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 61 "..\..\MVC\Views\CourseDetail\Index.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-latest-course-single\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t<figure");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-latest-course-img\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t<a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, "><img");

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 1506), Tuple.Create("\"", 1547)

#line 64 "..\..\MVC\Views\CourseDetail\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1512), Tuple.Create<System.Object, System.Int32>(courseDetail.GetValue("ImageLink")

#line default
#line hidden
, 1512), false)
);

WriteLiteralTo(__razor_helper_writer, " alt=\"img\"");

WriteLiteralTo(__razor_helper_writer, "></a>\r\n\t\t\t<figcaption");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-latest-course-imgcaption\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t\t<a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 66 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, courseDetail.GetValue("Type"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n\t\t\t\t<span><i");

WriteLiteralTo(__razor_helper_writer, " class=\"fa fa-clock-o\"");

WriteLiteralTo(__razor_helper_writer, "></i>");


#line 67 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                     WriteTo(__razor_helper_writer, courseDetail.GetValue("Days"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " Days</span>\r\n\t\t\t</figcaption>\r\n\t\t</figure>\r\n\t\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-latest-course-single-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t<h2><a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 71 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, courseDetail.GetValue("DisplayTitle"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></h2>\r\n\t\t\t<h4>Course Information</h4>\r\n\t\t\t<ul>\r\n\t\t\t\t<li> <span>Course Price</" +
"span> <span>");


#line 74 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                       WriteTo(__razor_helper_writer, courseDetail.GetValue("Price"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></li>\r\n\t\t\t\t<li> <span>Place</span> <span>");


#line 75 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                WriteTo(__razor_helper_writer, courseDetail.GetValue("Place"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></li>\r\n\t\t\t\t<li> <span>Total Students</span> <span>");


#line 76 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                         WriteTo(__razor_helper_writer, courseDetail.GetValue("TotalStudent"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></li>\r\n\t\t\t\t<li> <span>Course Duration</span> <span>");


#line 77 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                          WriteTo(__razor_helper_writer, courseDetail.GetValue("CourseDuration"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></li>\r\n\t\t\t\t<li> <span>Course Start</span> <span>");


#line 78 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                       WriteTo(__razor_helper_writer, courseDetail.GetValue("CourseStart"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span></li>\r\n\t\t\t</ul>\r\n\t\t\t<h4>Description</h4>\r\n");

WriteLiteralTo(__razor_helper_writer, "\t\t\t");


#line 81 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(courseDetail.GetValue("LongDescription")));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "\t\t\t");


#line 82 "..\..\MVC\Views\CourseDetail\Index.cshtml"
WriteTo(__razor_helper_writer, RenderCourseOutline(Model.Outlines));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\t\t</div>\r\n\t</div>\r\n");


#line 85 "..\..\MVC\Views\CourseDetail\Index.cshtml"


#line default
#line hidden
});

#line 85 "..\..\MVC\Views\CourseDetail\Index.cshtml"
}
#line default
#line hidden

#line 87 "..\..\MVC\Views\CourseDetail\Index.cshtml"
public System.Web.WebPages.HelperResult RenderRelatedCourses(List<DynamicContent> relatedCourses) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 87 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                                                                   


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"row\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"col-md-12\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-related-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t\t<h3>Related Courses</h3>\r\n\t\t\t\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"mu-related-item-area\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\t\t\t\t\t<div");

WriteLiteralTo(__razor_helper_writer, " id=\"mu-related-item-slide\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 94 "..\..\MVC\Views\CourseDetail\Index.cshtml"
						

#line default
#line hidden

#line 94 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                         foreach (var course in relatedCourses)
						{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t\t\t\t\t\t\t<div");

WriteLiteralTo(__razor_helper_writer, " class=\"col-md-6\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 97 "..\..\MVC\Views\CourseDetail\Index.cshtml"
								

#line default
#line hidden

#line 97 "..\..\MVC\Views\CourseDetail\Index.cshtml"
                                   Html.RenderPartial("_SliderTileCourse", course); 

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\t\t\t\t\t\t\t</div>\r\n");


#line 99 "..\..\MVC\Views\CourseDetail\Index.cshtml"
						}


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");


#line 105 "..\..\MVC\Views\CourseDetail\Index.cshtml"


#line default
#line hidden
});

#line 105 "..\..\MVC\Views\CourseDetail\Index.cshtml"
}
#line default
#line hidden

        public _MVC_Views_CourseDetail_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\MVC\Views\CourseDetail\Index.cshtml"
  
	Layout = "~/MVC/Views/Layouts/_MVCLayout.cshtml";
	Page.Title = "Course Detail";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 12 "..\..\MVC\Views\CourseDetail\Index.cshtml"
  
	var courseDetail = Model.CourseDetail;
	var relatedCourses = Model.RelatedCourses;
	var pageName = Page.Title as string;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n");

            
            #line 19 "..\..\MVC\Views\CourseDetail\Index.cshtml"
	
            
            #line default
            #line hidden
            
            #line 19 "..\..\MVC\Views\CourseDetail\Index.cshtml"
       Html.RenderPartial("_Breadcrumb", pageName); 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"mu-course-container mu-course-details\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 26 "..\..\MVC\Views\CourseDetail\Index.cshtml"
           Write(RenderCourseDetail(Model.CourseDetail));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");

WriteLiteral("\t");

            
            #line 30 "..\..\MVC\Views\CourseDetail\Index.cshtml"
Write(RenderRelatedCourses(relatedCourses));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
