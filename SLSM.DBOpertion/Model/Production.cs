using System;

namespace DbOpertion.Models
{
    [Serializable]
    public class Production
    {
        /// <summary>
        /// 生产管理单
        /// </summary>
        public Int32 Id { get; set; }
        /// <summary>
        /// 生产管理单编号
        /// </summary>
        public String ProductionNo { get; set; }
        /// <summary>
        /// 订单表
        /// </summary>
        public Int32? order_detailId { get; set; }
        /// <summary>
        /// 设计师状态
        /// </summary>
        public String DesignerStatus { get; set; }
        /// <summary>
        /// 设计文件
        /// </summary>
        public String DesignerZip { get; set; }
        /// <summary>
        /// 生产状态
        /// </summary>
        public String ProductionStatus { get; set; }
        /// <summary>
        /// 生产文件
        /// </summary>
        public String ProductionZip { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public String OrderStatus { get; set; }
        /// <summary>
        /// 订单类型(常规定制,样品,打样)
        /// </summary>
        public String OrderType { get; set; }
        /// <summary>
        /// 交货时间
        /// </summary>
        public DateTime? deliveryTime { get; set; }
        /// <summary>
        /// 品检状态
        /// </summary>
        public String InspectionStatus { get; set; }
        /// <summary>
        /// 退回次数
        /// </summary>
        public Int32? ReturnCount { get; set; }
        /// <summary>
        /// 退回原因
        /// </summary>
        public String ReturnContext { get; set; }
        /// <summary>
        /// 生产注意事项
        /// </summary>
        public String InspectionContext { get; set; }
        /// <summary>
        /// 客服反馈
        /// </summary>
        public String ServiceContext { get; set; }
        /// <summary>
        /// 收件人
        /// </summary>
        public String AddresseeName { get; set; }
        /// <summary>
        /// 收件人电话
        /// </summary>
        public String AddresseePhone { get; set; }
        /// <summary>
        /// 选择快递公司
        /// </summary>
        public String ExpressCompany { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public String ExpressNo { get; set; }
        /// <summary>
        /// 称重重量
        /// </summary>
        public Double? ExpressWeight { get; set; }
        /// <summary>
        /// 快递单备注
        /// </summary>
        public String ExpressContext { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        public String ProductionPerson { get; set; }
        /// <summary>
        /// 制单时间
        /// </summary>
        public DateTime? ProductionTime { get; set; }
        /// <summary>
        /// 设计师名字
        /// </summary>
        public String DesigerPerson { get; set; }
        /// <summary>
        /// 客服名字
        /// </summary>
        public String KefuPerson { get; set; }
        /// <summary>
        /// 销售员
        /// </summary>
        public String SalePerson { get; set; }
        /// <summary>
        /// 印刷工艺
        /// </summary>
        public String PrintInfo { get; set; }
        /// <summary>
        /// 印刷参数
        /// </summary>
        public String PrintParm { get; set; }
        /// <summary>
        /// 验货员
        /// </summary>
        public String Inspector { get; set; }
        /// <summary>
        /// 不良信息
        /// </summary>
        public String BadInfo { get; set; }
        /// <summary>
        /// 检验结果
        /// </summary>
        public String TestResults { get; set; }
        /// <summary>
        /// 产品图片
        /// </summary>
        public String ProductImageInfo { get; set; }
        /// <summary>
        /// 验货日期
        /// </summary>
        public DateTime? INSPECTIONDATE { get; set; }
        /// <summary>
        /// 验货员
        /// </summary>
        public String QCINSPECTOR { get; set; }

    }
}
