﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceApp.Model;

namespace WcfServiceApp
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
	public class StudentService : IStudentService
	{
		public void AddStudent(student obj)
		{
			//student obj = new student();
			StudentsDBEntities1 entity = new StudentsDBEntities1 ();
			entity.students.Add(obj);
			entity.SaveChanges();

		}
	}
}
