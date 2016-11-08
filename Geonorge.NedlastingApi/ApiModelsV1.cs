﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Koden er generert av et verktøy.
//     Kjøretidsversjon:4.0.30319.34014
//
//     Endringer i denne filen kan føre til feil virkemåte, og vil gå tapt hvis
//     koden genereres på nytt.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace Geonorge.NedlastingApi.V1
{

    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.33440.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Area", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class AreaType
    {

        private string codeField;

        private string typeField;

        private string nameField;

        private ProjectionType[] projectionsField;

        private FormatType[] formatsField;

        /// <remarks/>
        /// <summary>
        /// The areacode
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The type of area ex. municipality
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The name of the area
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The projections available for this area
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProjectionType[] projections
        {
            get { return this.projectionsField; }
            set { this.projectionsField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The formats available for this area
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FormatType[] formats
        {
            get { return this.formatsField; }
            set { this.formatsField = value; }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Area", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class OrderAreaType
    {

        private string codeField;

        private string typeField;

        private string nameField;

        /// <remarks/>
        /// <summary>
        /// The areacode
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The type of area ex. municipality
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The name of the area
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.kxml.no/rest/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Link", Namespace = "http://www.kxml.no/rest/1.0", IsNullable = false)]
    public partial class LinkType
    {

        private string hrefField;

        private string relField;

        private bool templatedField;

        private bool templatedFieldSpecified;

        private string typeField;

        private string deprecationField;

        private string nameField;

        private string titleField;

        /// <remarks/>
        /// <summary>
        /// Announce where to get the resource
        /// </summary>
        public string href
        {
            get { return this.hrefField; }
            set { this.hrefField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Announce the relation/key of the resource
        /// </summary>
        public string rel
        {
            get { return this.relField; }
            set { this.relField = value; }
        }

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //public bool templated {
        //    get {
        //        return this.templatedField;
        //    }
        //    set {
        //        this.templatedField = value;
        //    }
        //}

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool templatedSpecified {
        //    get {
        //        return this.templatedFieldSpecified;
        //    }
        //    set {
        //        this.templatedFieldSpecified = value;
        //    }
        //}

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //public string type {
        //    get {
        //        return this.typeField;
        //    }
        //    set {
        //        this.typeField = value;
        //    }
        //}

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //public string deprecation {
        //    get {
        //        return this.deprecationField;
        //    }
        //    set {
        //        this.deprecationField = value;
        //    }
        //}

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //public string name {
        //    get {
        //        return this.nameField;
        //    }
        //    set {
        //        this.nameField = value;
        //    }
        //}

        ///// <remarks/>
        ///// <summary>
        ///// Not in use
        ///// </summary>
        //public string title {
        //    get {
        //        return this.titleField;
        //    }
        //    set {
        //        this.titleField = value;
        //    }
        //}
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Capabilities", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false
        )]
    public partial class CapabilitiesType
    {

        private System.Nullable<bool> supportsProjectionSelectionField;

        private System.Nullable<bool> supportsFormatSelectionField;

        private System.Nullable<bool> supportsPolygonSelectionField;

        private System.Nullable<bool> supportsAreaSelectionField;

        private string mapSelectionLayerField;

        private LinkType[] _linksField;

        /// <remarks/>
        /// <summary>
        /// Indicates if the service supports projection selection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> supportsProjectionSelection
        {
            get { return this.supportsProjectionSelectionField; }
            set { this.supportsProjectionSelectionField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Indicates if the service supports format selection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> supportsFormatSelection
        {
            get { return this.supportsFormatSelectionField; }
            set { this.supportsFormatSelectionField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Indicates if the service supports polygon selection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> supportsPolygonSelection
        {
            get { return this.supportsPolygonSelectionField; }
            set { this.supportsPolygonSelectionField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Indicates if the service supports area selection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> supportsAreaSelection
        {
            get { return this.supportsAreaSelectionField; }
            set { this.supportsAreaSelectionField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Reference to selection layer to show in map
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string mapSelectionLayer
        {
            get { return this.mapSelectionLayerField; }
            set { this.mapSelectionLayerField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Describes where the rest of the resources are found
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("_links", Namespace = "http://www.kxml.no/rest/1.0", IsNullable = false)]
        public LinkType[] _links
        {
            get { return this._linksField; }
            set { this._linksField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("File", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class FileType
    {

        private string downloadUrlField;

        private string fileSizeField;

        private string nameField;

        /// <remarks/>
        /// <summary>
        /// Url to download file
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string downloadUrl
        {
            get { return this.downloadUrlField; }
            set { this.downloadUrlField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Not available
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", IsNullable = true)]
        public string fileSize
        {
            get { return this.fileSizeField; }
            set { this.fileSizeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The filename
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Format", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class FormatType
    {

        private string nameField;

        private string versionField;

        /// <remarks/>
        /// <summary>
        /// The name of the format
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// Version info
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string version
        {
            get { return this.versionField; }
            set { this.versionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Order", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class OrderType
    {

        private string emailField;

        private OrderLineType[] orderLinesField;

        /// <remarks/>
        /// <summary>
        /// The email of the person that wish to download
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The selection of metadata including areas, projections and formats to download.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderLineType[] orderLines
        {
            get { return this.orderLinesField; }
            set { this.orderLinesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class OrderLineType
    {

        private OrderAreaType[] areasField;

        private FormatType[] formatsField;

        private string metadataUuidField;

        private string coordinatesField;

        private string coordinatesystemField;

        private ProjectionType[] projectionsField;

        /// <summary>
        /// Set selected areas for download
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("area", IsNullable = false)]
        public OrderAreaType[] areas
        {
            get { return this.areasField; }
            set { this.areasField = value; }
        }

        /// <summary>
        /// Set selected formats to download
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("format", IsNullable = false)]
        public FormatType[] formats
        {
            get { return this.formatsField; }
            set { this.formatsField = value; }
        }

        /// <summary>
        /// A uniqe reference to datasett from kartkatalog.geonorge.no
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string metadataUuid
        {
            get { return this.metadataUuidField; }
            set { this.metadataUuidField = value; }
        }

        /// <summary>
        /// If polygon is selected this includes coordinates. Values are separated by space.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string coordinates
        {
            get { return this.coordinatesField; }
            set { this.coordinatesField = value; }
        }

        /// <summary>
        /// If polygon is selected this includes coordinate system. Default epsg code is 32633
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string coordinatesystem
        {
            get { return this.coordinatesystemField; }
            set { this.coordinatesystemField = value; }
        }

        /// <summary>
        /// Selected projections to download
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("projection", IsNullable = false)]
        public ProjectionType[] projections
        {
            get { return this.projectionsField; }
            set { this.projectionsField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("Projection", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false)]
    public partial class ProjectionType
    {

        private string codeField;

        private string nameField;

        private string codespaceField;

        /// <remarks/>
        /// <summary>
        /// The identifier code (epsg) of the projection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The name (coordinate system) of the projection
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The codespace reference. Not required for OrderLineType
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string codespace
        {
            get { return this.codespaceField; }
            set { this.codespaceField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://skjema.geonorge.no/SOSI/download/0.5")]
    [System.Xml.Serialization.XmlRootAttribute("OrderReceipt", Namespace = "http://skjema.geonorge.no/SOSI/download/0.5", IsNullable = false
        )]
    public partial class OrderReceiptType
    {

        private string referenceNumberField;

        private FileType[] filesField;

        /// <remarks/>
        /// <summary>
        /// The order number generated by the system
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string referenceNumber
        {
            get { return this.referenceNumberField; }
            set { this.referenceNumberField = value; }
        }

        /// <remarks/>
        /// <summary>
        /// The list of files returned from order. Polygon selection is sendt by email with link to download.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("file", IsNullable = false)]
        public FileType[] files
        {
            get { return this.filesField; }
            set { this.filesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.kxml.no/rest/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("LinkListe", Namespace = "http://www.kxml.no/rest/1.0", IsNullable = false)]
    public partial class LinkListeType
    {

        private LinkType[] _linksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_links")]
        public LinkType[] _links
        {
            get { return this._linksField; }
            set { this._linksField = value; }
        }
    }
}