using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPWebApplicationWithVueJS.ViewModel
{
    public class EmpViewModel
    {
        /// <summary>
        /// 隱藏欄位(登入ID)
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 查詢名稱
        /// </summary>
        [DisplayName("名稱")]
        [Required(ErrorMessage = "請輸入查詢名稱")]
        public string Name { get; set; }

        /// <summary>
        /// 查詢編號
        /// </summary>
        [DisplayName("編號")]
        [Range(1, 1000, ErrorMessage = "範圍值為1~999")]
        [Required(ErrorMessage = "請輸入查詢編號")]
        public int Number { get; set; }
    }
}