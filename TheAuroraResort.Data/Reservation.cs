using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Data
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public enum ActivityName { WaterPark = 1, ZipLining, WaterSkiing, LiveShow }

        public Guid UserId { get; set; }

        [Required]
        public virtual int ProfileId { get;  set; }

        [Required]
        public string UserEmail { get; set; }
        public DateTimePicker ReservationDateTime { get; set; }

        public void SetDateTimePickerFormat()
        {
            ReservationDateTime.Format = DateTimePickerFormat.Custom;
            ReservationDateTime.CustomFormat = "MMMM dd, yyyy - t:mm tt";
        }

        private void InitializeDateTimePicker()
        {
            // Construct the DateTimePicker.
            this.ReservationDateTime = new System.Windows.Forms.DateTimePicker();

            //Set size and location.
            this.ReservationDateTime.Location = new System.Drawing.Point(40, 88);
            this.ReservationDateTime.Size = new System.Drawing.Size(160, 21);

            // Set the alignment of the drop-down MonthCalendar to right.
            this.ReservationDateTime.DropDownAlign = LeftRightAlignment.Right;

            // Set the Value property to 50 years before today.
            ReservationDateTime.Value = System.DateTime.Now.AddYears(-50);

            //Set a custom format containing the string "of the year"
            ReservationDateTime.Format = DateTimePickerFormat.Custom;
            ReservationDateTime.CustomFormat = "MMM dd, 'of the year' yyyy ";

            // Add the DateTimePicker to the form.
            Forms.Controls.Add(this.ReservationDateTime);
        }



        //DateTimePicker//
        //edit models
        //display name
        //Store as one variable

        public virtual int RestaurantId { get; set; }
        public int ActivityId { get; set; }

        [Required]
        public int PartySize { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }

    
}

