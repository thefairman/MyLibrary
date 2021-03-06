﻿using MyLibrary.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataDomain.Entities
{
    [Table("groups")]
    public class Group : DBEntity
    {

        [StringLength(64)]
        [Column("groupName")]
        public string Name { get; set; }
        public Faculty Faculty { get; set; }

        [Column("facultyId")]
        public Guid FacultyId { get; set; }
        public List<Student> Students { get; set; }
    }

}
