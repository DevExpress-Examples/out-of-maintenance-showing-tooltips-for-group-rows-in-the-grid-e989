using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace E989 {
    public class Record {
        public Record() {
        }
        int id;
        public int ID {
            get { return id; }
            set {
                if(id != value) {
                    id = value;
                }
            }
        }
        int parentID;
        public int ParentID {
            get { return parentID; }
            set {
                if(parentID != value) {
                    parentID = value;
                }
            }
        }
        string text;
        public string Text {
            get { return text; }
            set {
                if(text != value) {
                    text = value;
                }
            }
        }
        string info;
        public string Info {
            get { return info; }
            set {
                if(info != value) {
                    info = value;
                }
            }
        }
        decimal val;
        public decimal Value {
            get { return val; }
            set {
                if(val != value) {
                    val = value;
                }
            }
        }
        TimeSpan dt;
        public TimeSpan Dt {
            get { return dt; }
            set {
                if(dt != value) {
                    dt = value;
                }
            }
        }
        bool state;
        public bool State {
            get { return state; }
            set {
                if(state != value) {
                    state = value;
                }
            }
        }
        Image image;
        public Image Image {
            get { return image; }
            set {
                if(image != value) {
                    image = value;
                }
            }
        }
    }
    public class DataHelper {
        public static BindingList<Record> GetData(int count) {
            BindingList<Record> records = new BindingList<Record>();
            for(int i = 0; i < count; i++)
                records.Add(new Record() {
                    ID = i,
                    ParentID = i > 10 ? i % 5 : i % 2,
                    Text = string.Format("Text{0}", i),
                    Dt = TimeSpan.FromHours(i),
                    Value = i % 2 == 0 ? (i * 1.1222213M) : (i * 1.02312M),
                    State = i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Info = string.Format("Info{0}", i % 2 == 0 ? i : i + 2),
                });
            return records;
        }
    }
}
