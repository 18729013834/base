using System;
using System.Web.Mvc;
using System.Collections.Generic;
using case1.Services.Interfaces.srctest6;
using case1.Entities.srctest6;
using case1.Web.Models.srctest6;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using case1.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace case1.Web.Controllers.srctest6
{
	public class Student1Controller:CommonController<Student1, IStudent1Service, Student1Model>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "srctest6_Student1";
		}
		[HttpPost]
        [ValidateInput(false)]
        public override ActionResult Create(Student1Model model)
        {
            try
            {
                this.LoadViewReferenceData(model);
                if (this.ModelState.IsValid)
                {
                    Student1 entity = new Student1();
                    model.PopulateTo(entity);
		
                    this.DoInsert(entity);

                    return this.RedirectToAction("Index");
                }
                
                return this.ToAction("Create", model);
            }
            catch
            {
                return this.ToAction("Create", model);
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public override ActionResult Edit(Student1Model model)
        {
            try
            {
                this.LoadViewReferenceData(model);
                if (this.ModelState.IsValid)
                {
                    Student1 selectEntity = this.GetEntity(model.Id);
                    if (selectEntity == null)
                    {
                        return this.Json(new RequestResult() { IsSucceed = false, Message = DataIsNotExist }, JsonRequestBehavior.AllowGet);
                    }

                    Student1 modifyEntity = new Student1();
                    model.PopulateTo(modifyEntity);
                    this.DoUpdate(modifyEntity);

                    return this.RedirectToAction("Index");
                }

                return this.ToAction("Edit", model);
            }
            catch
            {
                return this.ToAction("Edit", model);
            }
        }

		protected override List<Student1> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Student1> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Student1 { Name = pagerSearchModel.Name }, student1 => student1.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
