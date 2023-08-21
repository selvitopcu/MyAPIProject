﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {

        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görselini griniz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz")]
        public string BadCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]
        public string Description { get; set; }
    }
}
