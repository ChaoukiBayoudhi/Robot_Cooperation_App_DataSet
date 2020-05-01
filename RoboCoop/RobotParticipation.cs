using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCoop
{
    public partial class RobotParticipation : Form
    {
        public RobotParticipation()
        {
            InitializeComponent();
        }

        private void RobotParticipation_Load(object sender, EventArgs e)
        {
            /*var res = (from r in Form1.dbRobot.Robots
                        join tr in Form1.dbRobot.TachesRobots on r.Id equals tr.IdRobot
                        join t in Form1.dbRobot.Tasks
                            on tr.CodeTask  equals t.code  into details
                        from d in details
                       select new { d. }
                        ).ToList();

            var q = (from product in dataContext.Products
                     join order in dataContext.Orders on product.ProductId equals order.ProductId
                     join cust in dataContext.Customers on order.CustomerId equals cust.CustomerId
                     orderby order.OrderId
                     select new
                     {
                         order.OrderId,
                         product.ProductId,
                         product.ProductName,
                         product.Price,
                         order.Quantity,
                         Customer = cust.Name
                     }).ToList();

            var q = (from product in dataContext.Products
                     join order in dataContext.Orders on product.ProductId equals order.ProductId
                     join cust in dataContext.Customers on new
                     {
                         custid = order.CustomerId,
                         pid = order.ProductId
                     }
equals new
{
custid = cust.CustomerId,
pid = cust.ProductId
}
                     orderby order.OrderId
                     select new
                     {
                         order.OrderId,
                         product.ProductId,
                         product.ProductName,
                         product.Price,
                         order.Quantity,
                         Customer = cust.Name
                     }).ToList();
                     */
        }
    }
}
