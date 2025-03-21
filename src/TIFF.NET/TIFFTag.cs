namespace TagImageFileFormat;

public enum TIFFTag
{
    /// <summary>Tag placeholder</summary>
    IGNORE = 0,

    /// <summary>
    /// Subfile data descriptor.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.FileType" />.
    /// </summary>
    SUBFILETYPE = 254, // 0x000000FE

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Kind of data in subfile. For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.OFileType" />.
    /// </summary>
    OSUBFILETYPE = 255, // 0x000000FF

    /// <summary>Image width in pixels.</summary>
    IMAGEWIDTH = 256, // 0x00000100

    /// <summary>Image height in pixels.</summary>
    IMAGELENGTH = 257, // 0x00000101

    /// <summary>Bits per channel (sample).</summary>
    BITSPERSAMPLE = 258, // 0x00000102

    /// <summary>
    /// Data compression technique.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Compression" />.
    /// </summary>
    COMPRESSION = 259, // 0x00000103

    /// <summary>
    /// Photometric interpretation.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Photometric" />.
    /// </summary>
    PHOTOMETRIC = 262, // 0x00000106

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Thresholding used on data. For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Threshold" />.
    /// </summary>
    THRESHHOLDING = 263, // 0x00000107

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Dithering matrix width.
    /// </summary>
    CELLWIDTH = 264, // 0x00000108

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Dithering matrix height.
    /// </summary>
    CELLLENGTH = 265, // 0x00000109

    /// <summary>
    /// Data order within a byte.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.FillOrder" />.
    /// </summary>
    FILLORDER = 266, // 0x0000010A

    /// <summary>Name of document which holds for image.</summary>
    DOCUMENTNAME = 269, // 0x0000010D

    /// <summary>Information about image.</summary>
    IMAGEDESCRIPTION = 270, // 0x0000010E

    /// <summary>Scanner manufacturer name.</summary>
    MAKE = 271, // 0x0000010F

    /// <summary>Scanner model name/number.</summary>
    MODEL = 272, // 0x00000110

    /// <summary>Offsets to data strips.</summary>
    STRIPOFFSETS = 273, // 0x00000111

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Image orientation. For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Orientation" />.
    /// </summary>
    ORIENTATION = 274, // 0x00000112

    /// <summary>Samples per pixel.</summary>
    SAMPLESPERPIXEL = 277, // 0x00000115

    /// <summary>Rows per strip of data.</summary>
    ROWSPERSTRIP = 278, // 0x00000116

    /// <summary>Bytes counts for strips.</summary>
    STRIPBYTECOUNTS = 279, // 0x00000117

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Minimum sample value.
    /// </summary>
    MINSAMPLEVALUE = 280, // 0x00000118

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Maximum sample value.
    /// </summary>
    MAXSAMPLEVALUE = 281, // 0x00000119

    /// <summary>Pixels/resolution in x.</summary>
    XRESOLUTION = 282, // 0x0000011A

    /// <summary>Pixels/resolution in y.</summary>
    YRESOLUTION = 283, // 0x0000011B

    /// <summary>
    /// Storage organization.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.PlanarConfig" />.
    /// </summary>
    PLANARCONFIG = 284, // 0x0000011C

    /// <summary>Page name image is from.</summary>
    PAGENAME = 285, // 0x0000011D

    /// <summary>X page offset of image lhs.</summary>
    XPOSITION = 286, // 0x0000011E

    /// <summary>Y page offset of image lhs.</summary>
    YPOSITION = 287, // 0x0000011F

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Byte offset to free block.
    /// </summary>
    FREEOFFSETS = 288, // 0x00000120

    /// <summary>
    /// [obsoleted by TIFF rev. 5.0]<br />
    /// Sizes of free blocks.
    /// </summary>
    FREEBYTECOUNTS = 289, // 0x00000121

    /// <summary>
    /// [obsoleted by TIFF rev. 6.0]<br />
    /// Gray scale curve accuracy.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.GrayResponseUnit" />.
    /// </summary>
    GRAYRESPONSEUNIT = 290, // 0x00000122

    /// <summary>
    /// [obsoleted by TIFF rev. 6.0]<br />
    /// Gray scale response curve.
    /// </summary>
    GRAYRESPONSECURVE = 291, // 0x00000123

    /// <summary>
    /// Options for CCITT Group 3 fax encoding. 32 flag bits.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Group3Opt" />.
    /// </summary>
    GROUP3OPTIONS = 292, // 0x00000124

    /// <summary>TIFF 6.0 proper name alias for GROUP3OPTIONS.</summary>
    T4OPTIONS = 292, // 0x00000124

    /// <summary>
    /// Options for CCITT Group 4 fax encoding. 32 flag bits.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Group3Opt" />.
    /// </summary>
    GROUP4OPTIONS = 293, // 0x00000125

    /// <summary>TIFF 6.0 proper name alias for GROUP4OPTIONS.</summary>
    T6OPTIONS = 293, // 0x00000125

    /// <summary>
    /// Units of resolutions.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.ResUnit" />.
    /// </summary>
    RESOLUTIONUNIT = 296, // 0x00000128

    /// <summary>Page numbers of multi-page.</summary>
    PAGENUMBER = 297, // 0x00000129

    /// <summary>
    /// [obsoleted by TIFF rev. 6.0]<br />
    /// Color curve accuracy.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.ColorResponseUnit" />.
    /// </summary>
    COLORRESPONSEUNIT = 300, // 0x0000012C

    /// <summary>Colorimetry info.</summary>
    TRANSFERFUNCTION = 301, // 0x0000012D

    /// <summary>Name &amp; release.</summary>
    SOFTWARE = 305, // 0x00000131

    /// <summary>Creation date and time.</summary>
    DATETIME = 306, // 0x00000132

    /// <summary>Creator of image.</summary>
    ARTIST = 315, // 0x0000013B

    /// <summary>Machine where created.</summary>
    HOSTCOMPUTER = 316, // 0x0000013C

    /// <summary>
    /// Prediction scheme w/ LZW.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.Predictor" />.
    /// </summary>
    PREDICTOR = 317, // 0x0000013D

    /// <summary>Image white point.</summary>
    WHITEPOINT = 318, // 0x0000013E

    /// <summary>Primary chromaticities.</summary>
    PRIMARYCHROMATICITIES = 319, // 0x0000013F

    /// <summary>RGB map for pallette image.</summary>
    COLORMAP = 320, // 0x00000140

    /// <summary>Highlight + shadow info.</summary>
    HALFTONEHINTS = 321, // 0x00000141

    /// <summary>Tile width in pixels.</summary>
    TILEWIDTH = 322, // 0x00000142

    /// <summary>Tile height in pixels.</summary>
    TILELENGTH = 323, // 0x00000143

    /// <summary>Offsets to data tiles.</summary>
    TILEOFFSETS = 324, // 0x00000144

    /// <summary>Byte counts for tiles.</summary>
    TILEBYTECOUNTS = 325, // 0x00000145

    /// <summary>Lines with wrong pixel count.</summary>
    BADFAXLINES = 326, // 0x00000146

    /// <summary>
    /// Regenerated line info.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.CleanFaxData" />.
    /// </summary>
    CLEANFAXDATA = 327, // 0x00000147

    /// <summary>Max consecutive bad lines.</summary>
    CONSECUTIVEBADFAXLINES = 328, // 0x00000148

    /// <summary>Subimage descriptors.</summary>
    SUBIFD = 330, // 0x0000014A

    /// <summary>
    /// Inks in separated image.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.InkSet" />.
    /// </summary>
    INKSET = 332, // 0x0000014C

    /// <summary>ASCII names of inks.</summary>
    INKNAMES = 333, // 0x0000014D

    /// <summary>Number of inks.</summary>
    NUMBEROFINKS = 334, // 0x0000014E

    /// <summary>0% and 100% dot codes.</summary>
    DOTRANGE = 336, // 0x00000150

    /// <summary>Separation target.</summary>
    TARGETPRINTER = 337, // 0x00000151

    /// <summary>
    /// Information about extra samples.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.ExtraSample" />.
    /// </summary>
    EXTRASAMPLES = 338, // 0x00000152

    /// <summary>
    /// Data sample format.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.SampleFormat" />.
    /// </summary>
    SAMPLEFORMAT = 339, // 0x00000153

    /// <summary>Variable MinSampleValue.</summary>
    SMINSAMPLEVALUE = 340, // 0x00000154

    /// <summary>Variable MaxSampleValue.</summary>
    SMAXSAMPLEVALUE = 341, // 0x00000155

    /// <summary>
    /// ClipPath. Introduced post TIFF rev 6.0 by Adobe TIFF technote 2.
    /// </summary>
    CLIPPATH = 343, // 0x00000157

    /// <summary>
    /// XClipPathUnits. Introduced post TIFF rev 6.0 by Adobe TIFF technote 2.
    /// </summary>
    XCLIPPATHUNITS = 344, // 0x00000158

    /// <summary>
    /// YClipPathUnits. Introduced post TIFF rev 6.0 by Adobe TIFF technote 2.
    /// </summary>
    YCLIPPATHUNITS = 345, // 0x00000159

    /// <summary>
    /// Indexed. Introduced post TIFF rev 6.0 by Adobe TIFF Technote 3.
    /// </summary>
    INDEXED = 346, // 0x0000015A

    /// <summary>JPEG table stream. Introduced post TIFF rev 6.0.</summary>
    JPEGTABLES = 347, // 0x0000015B

    /// <summary>
    /// OPI Proxy. Introduced post TIFF rev 6.0 by Adobe TIFF technote.
    /// </summary>
    OPIPROXY = 351, // 0x0000015F

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// JPEG processing algorithm.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.JpegProc" />.
    /// </summary>
    JPEGPROC = 512, // 0x00000200

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// Pointer to SOI marker.
    /// </summary>
    JPEGIFOFFSET = 513, // 0x00000201

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// JFIF stream length
    /// </summary>
    JPEGIFBYTECOUNT = 514, // 0x00000202

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// Restart interval length.
    /// </summary>
    JPEGRESTARTINTERVAL = 515, // 0x00000203

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// Lossless proc predictor.
    /// </summary>
    JPEGLOSSLESSPREDICTORS = 517, // 0x00000205

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// Lossless point transform.
    /// </summary>
    JPEGPOINTTRANSFORM = 518, // 0x00000206

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// Q matrice offsets.
    /// </summary>
    JPEGQTABLES = 519, // 0x00000207

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// DCT table offsets.
    /// </summary>
    JPEGDCTABLES = 520, // 0x00000208

    /// <summary>
    /// [obsoleted by Technical Note #2 which specifies a revised JPEG-in-TIFF scheme]<br />
    /// AC coefficient offsets.
    /// </summary>
    JPEGACTABLES = 521, // 0x00000209

    /// <summary>RGB -&gt; YCbCr transform.</summary>
    YCBCRCOEFFICIENTS = 529, // 0x00000211

    /// <summary>YCbCr subsampling factors.</summary>
    YCBCRSUBSAMPLING = 530, // 0x00000212

    /// <summary>
    /// Subsample positioning.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.YCbCrPosition" />.
    /// </summary>
    YCBCRPOSITIONING = 531, // 0x00000213

    /// <summary>Colorimetry info.</summary>
    REFERENCEBLACKWHITE = 532, // 0x00000214

    /// <summary>
    /// XML packet. Introduced post TIFF rev 6.0 by Adobe XMP Specification, January 2004.
    /// </summary>
    XMLPACKET = 700, // 0x000002BC

    /// <summary>
    /// OPI ImageID. Introduced post TIFF rev 6.0 by Adobe TIFF technote.
    /// </summary>
    OPIIMAGEID = 32781, // 0x0000800D

    /// <summary>
    /// Image reference points. Private tag registered to Island Graphics.
    /// </summary>
    REFPTS = 32953, // 0x000080B9

    /// <summary>
    /// Region-xform tack point. Private tag registered to Island Graphics.
    /// </summary>
    REGIONTACKPOINT = 32954, // 0x000080BA

    /// <summary>
    /// Warp quadrilateral. Private tag registered to Island Graphics.
    /// </summary>
    REGIONWARPCORNERS = 32955, // 0x000080BB

    /// <summary>
    /// Affine transformation matrix. Private tag registered to Island Graphics.
    /// </summary>
    REGIONAFFINE = 32956, // 0x000080BC

    /// <summary>
    /// [obsoleted by TIFF rev. 6.0]<br />
    /// Use EXTRASAMPLE tag. Private tag registered to SGI.
    /// </summary>
    MATTEING = 32995, // 0x000080E3

    /// <summary>
    /// [obsoleted by TIFF rev. 6.0]<br />
    /// Use SAMPLEFORMAT tag. Private tag registered to SGI.
    /// </summary>
    DATATYPE = 32996, // 0x000080E4

    /// <summary>Z depth of image. Private tag registered to SGI.</summary>
    IMAGEDEPTH = 32997, // 0x000080E5

    /// <summary>Z depth/data tile. Private tag registered to SGI.</summary>
    TILEDEPTH = 32998, // 0x000080E6

    /// <summary>
    /// Full image size in X. This tag is set when an image has been cropped out of a larger
    /// image. It reflect width of the original uncropped image. The XPOSITION tag can be used
    /// to determine the position of the smaller image in the larger one.
    /// Private tag registered to Pixar.
    /// </summary>
    PIXAR_IMAGEFULLWIDTH = 33300, // 0x00008214

    /// <summary>
    /// Full image size in Y. This tag is set when an image has been cropped out of a larger
    /// image. It reflect height of the original uncropped image. The YPOSITION can be used
    /// to determine the position of the smaller image in the larger one.
    /// Private tag registered to Pixar.
    /// </summary>
    PIXAR_IMAGEFULLLENGTH = 33301, // 0x00008215

    /// <summary>
    /// Texture map format. Used to identify special image modes and data used by Pixar's
    /// texture formats. Private tag registered to Pixar.
    /// </summary>
    PIXAR_TEXTUREFORMAT = 33302, // 0x00008216

    /// <summary>
    /// S&amp;T wrap modes. Used to identify special image modes and data used by Pixar's
    /// texture formats. Private tag registered to Pixar.
    /// </summary>
    PIXAR_WRAPMODES = 33303, // 0x00008217

    /// <summary>
    /// Cotan(fov) for env. maps. Used to identify special image modes and data used by
    /// Pixar's texture formats. Private tag registered to Pixar.
    /// </summary>
    PIXAR_FOVCOT = 33304, // 0x00008218

    /// <summary>
    /// Used to identify special image modes and data used by Pixar's texture formats.
    /// Private tag registered to Pixar.
    /// </summary>
    PIXAR_MATRIX_WORLDTOSCREEN = 33305, // 0x00008219

    /// <summary>
    /// Used to identify special image modes and data used by Pixar's texture formats.
    /// Private tag registered to Pixar.
    /// </summary>
    PIXAR_MATRIX_WORLDTOCAMERA = 33306, // 0x0000821A

    /// <summary>
    /// Device serial number. Private tag registered to Eastman Kodak.
    /// </summary>
    WRITERSERIALNUMBER = 33405, // 0x0000827D

    /// <summary>
    /// Copyright string. This tag is listed in the TIFF rev. 6.0 w/ unknown ownership.
    /// </summary>
    COPYRIGHT = 33432, // 0x00008298

    /// <summary>Exposure time.</summary>
    EXIF_EXPOSURETIME = 33434, // 0x0000829A

    /// <summary>F number.</summary>
    EXIF_FNUMBER = 33437, // 0x0000829D

    /// <summary>
    /// This tag is defining exact affine transformations between raster and model space. Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_MODELPIXELSCALETAG = 33550, // 0x0000830E

    /// <summary>IPTC TAG from RichTIFF specifications.</summary>
    RICHTIFFIPTC = 33723, // 0x000083BB

    /// <summary>
    /// This tag stores raster-&gt;model tiepoint pairs. Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_MODELTIEPOINTTAG = 33922, // 0x00008482

    /// <summary>Site name. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8SITE = 34016, // 0x000084E0

    /// <summary>
    /// Color seq. [RGB, CMYK, etc]. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8COLORSEQUENCE = 34017, // 0x000084E1

    /// <summary>DDES Header. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8HEADER = 34018, // 0x000084E2

    /// <summary>
    /// Raster scanline padding. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8RASTERPADDING = 34019, // 0x000084E3

    /// <summary>
    /// The number of bits in short run. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8BITSPERRUNLENGTH = 34020, // 0x000084E4

    /// <summary>
    /// The number of bits in long run. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8BITSPEREXTENDEDRUNLENGTH = 34021, // 0x000084E5

    /// <summary>LW colortable. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8COLORTABLE = 34022, // 0x000084E6

    /// <summary>
    /// BP/BL image color switch. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8IMAGECOLORINDICATOR = 34023, // 0x000084E7

    /// <summary>BP/BL bg color switch. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8BKGCOLORINDICATOR = 34024, // 0x000084E8

    /// <summary>
    /// BP/BL image color value. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8IMAGECOLORVALUE = 34025, // 0x000084E9

    /// <summary>BP/BL bg color value. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8BKGCOLORVALUE = 34026, // 0x000084EA

    /// <summary>
    /// MP pixel intensity value. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8PIXELINTENSITYRANGE = 34027, // 0x000084EB

    /// <summary>
    /// HC transparency switch. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8TRANSPARENCYINDICATOR = 34028, // 0x000084EC

    /// <summary>
    /// Color characterization table. Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8COLORCHARACTERIZATION = 34029, // 0x000084ED

    /// <summary>HC usage indicator. Reserved for ANSI IT8 TIFF/IT.</summary>
    IT8HCUSAGE = 34030, // 0x000084EE

    /// <summary>
    /// Trapping indicator (untrapped = 0, trapped = 1). Reserved for ANSI IT8 TIFF/IT.
    /// </summary>
    IT8TRAPINDICATOR = 34031, // 0x000084EF

    /// <summary>CMYK color equivalents.</summary>
    IT8CMYKEQUIVALENT = 34032, // 0x000084F0

    /// <summary>
    /// Sequence Frame Count. Private tag registered to Texas Instruments.
    /// </summary>
    FRAMECOUNT = 34232, // 0x000085B8

    /// <summary>
    /// This tag is optionally provided for defining exact affine transformations between raster and model space. Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_MODELTRANSFORMATIONTAG = 34264, // 0x000085D8

    /// <summary>Private tag registered to Adobe for PhotoShop.</summary>
    PHOTOSHOP = 34377, // 0x00008649

    /// <summary>
    /// Pointer to EXIF private directory. This tag is documented in EXIF specification.
    /// </summary>
    EXIFIFD = 34665, // 0x00008769

    /// <summary>
    /// ICC profile data. ?? Private tag registered to Adobe. ??
    /// </summary>
    ICCPROFILE = 34675, // 0x00008773

    /// <summary>
    /// This tag may be used to store the GeoKey Directory, which defines and references the "GeoKeys". Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_GEOKEYDIRECTORYTAG = 34735, // 0x000087AF

    /// <summary>
    /// This tag is used to store all of the DOUBLE valued GeoKeys, referenced by the GeoKeyDirectoryTag. Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_GEODOUBLEPARAMSTAG = 34736, // 0x000087B0

    /// <summary>
    /// This tag is used to store all of the ASCII valued GeoKeys, referenced by the GeoKeyDirectoryTag. Used in interchangeable GeoTIFF files.
    /// </summary>
    GEOTIFF_GEOASCIIPARAMSTAG = 34737, // 0x000087B1

    /// <summary>JBIG options. Private tag registered to Pixel Magic.</summary>
    JBIGOPTIONS = 34750, // 0x000087BE

    /// <summary>Exposure program.</summary>
    EXIF_EXPOSUREPROGRAM = 34850, // 0x00008822

    /// <summary>Spectral sensitivity.</summary>
    EXIF_SPECTRALSENSITIVITY = 34852, // 0x00008824

    /// <summary>
    /// Pointer to GPS private directory. This tag is documented in EXIF specification.
    /// </summary>
    GPSIFD = 34853, // 0x00008825

    /// <summary>ISO speed rating.</summary>
    EXIF_ISOSPEEDRATINGS = 34855, // 0x00008827

    /// <summary>Optoelectric conversion factor.</summary>
    EXIF_OECF = 34856, // 0x00008828

    /// <summary>
    /// Encoded Class 2 ses. params. Private tag registered to SGI.
    /// </summary>
    FAXRECVPARAMS = 34908, // 0x0000885C

    /// <summary>
    /// Received SubAddr string. Private tag registered to SGI.
    /// </summary>
    FAXSUBADDRESS = 34909, // 0x0000885D

    /// <summary>Receive time (secs). Private tag registered to SGI.</summary>
    FAXRECVTIME = 34910, // 0x0000885E

    /// <summary>
    /// Encoded fax ses. params, Table 2/T.30. Private tag registered to SGI.
    /// </summary>
    FAXDCS = 34911, // 0x0000885F

    /// <summary>Private tag registered to FedEx.</summary>
    FEDEX_EDR = 34929, // 0x00008871

    /// <summary>Exif version.</summary>
    EXIF_EXIFVERSION = 36864, // 0x00009000

    /// <summary>Date and time of original data generation.</summary>
    EXIF_DATETIMEORIGINAL = 36867, // 0x00009003

    /// <summary>Date and time of digital data generation.</summary>
    EXIF_DATETIMEDIGITIZED = 36868, // 0x00009004

    /// <summary>Meaning of each component.</summary>
    EXIF_COMPONENTSCONFIGURATION = 37121, // 0x00009101

    /// <summary>Image compression mode.</summary>
    EXIF_COMPRESSEDBITSPERPIXEL = 37122, // 0x00009102

    /// <summary>Shutter speed.</summary>
    EXIF_SHUTTERSPEEDVALUE = 37377, // 0x00009201

    /// <summary>Aperture.</summary>
    EXIF_APERTUREVALUE = 37378, // 0x00009202

    /// <summary>Brightness.</summary>
    EXIF_BRIGHTNESSVALUE = 37379, // 0x00009203

    /// <summary>Exposure bias.</summary>
    EXIF_EXPOSUREBIASVALUE = 37380, // 0x00009204

    /// <summary>Maximum lens aperture.</summary>
    EXIF_MAXAPERTUREVALUE = 37381, // 0x00009205

    /// <summary>Subject distance.</summary>
    EXIF_SUBJECTDISTANCE = 37382, // 0x00009206

    /// <summary>Metering mode.</summary>
    EXIF_METERINGMODE = 37383, // 0x00009207

    /// <summary>Light source.</summary>
    EXIF_LIGHTSOURCE = 37384, // 0x00009208

    /// <summary>Flash.</summary>
    EXIF_FLASH = 37385, // 0x00009209

    /// <summary>Lens focal length.</summary>
    EXIF_FOCALLENGTH = 37386, // 0x0000920A

    /// <summary>Subject area.</summary>
    EXIF_SUBJECTAREA = 37396, // 0x00009214

    /// <summary>Sample value to Nits. Private tag registered to SGI.</summary>
    STONITS = 37439, // 0x0000923F

    /// <summary>Manufacturer notes.</summary>
    EXIF_MAKERNOTE = 37500, // 0x0000927C

    /// <summary>User comments.</summary>
    EXIF_USERCOMMENT = 37510, // 0x00009286

    /// <summary>DateTime subseconds.</summary>
    EXIF_SUBSECTIME = 37520, // 0x00009290

    /// <summary>DateTimeOriginal subseconds.</summary>
    EXIF_SUBSECTIMEORIGINAL = 37521, // 0x00009291

    /// <summary>DateTimeDigitized subseconds.</summary>
    EXIF_SUBSECTIMEDIGITIZED = 37522, // 0x00009292

    /// <summary>Supported Flashpix version.</summary>
    EXIF_FLASHPIXVERSION = 40960, // 0x0000A000

    /// <summary>Color space information.</summary>
    EXIF_COLORSPACE = 40961, // 0x0000A001

    /// <summary>Valid image width.</summary>
    EXIF_PIXELXDIMENSION = 40962, // 0x0000A002

    /// <summary>Valid image height.</summary>
    EXIF_PIXELYDIMENSION = 40963, // 0x0000A003

    /// <summary>Related audio file.</summary>
    EXIF_RELATEDSOUNDFILE = 40964, // 0x0000A004

    /// <summary>
    /// Pointer to Interoperability private directory.
    /// This tag is documented in EXIF specification.
    /// </summary>
    INTEROPERABILITYIFD = 40965, // 0x0000A005

    /// <summary>Flash energy.</summary>
    EXIF_FLASHENERGY = 41483, // 0x0000A20B

    /// <summary>Spatial frequency response.</summary>
    EXIF_SPATIALFREQUENCYRESPONSE = 41484, // 0x0000A20C

    /// <summary>Focal plane X resolution.</summary>
    EXIF_FOCALPLANEXRESOLUTION = 41486, // 0x0000A20E

    /// <summary>Focal plane Y resolution.</summary>
    EXIF_FOCALPLANEYRESOLUTION = 41487, // 0x0000A20F

    /// <summary>Focal plane resolution unit.</summary>
    EXIF_FOCALPLANERESOLUTIONUNIT = 41488, // 0x0000A210

    /// <summary>Subject location.</summary>
    EXIF_SUBJECTLOCATION = 41492, // 0x0000A214

    /// <summary>Exposure index.</summary>
    EXIF_EXPOSUREINDEX = 41493, // 0x0000A215

    /// <summary>Sensing method.</summary>
    EXIF_SENSINGMETHOD = 41495, // 0x0000A217

    /// <summary>File source.</summary>
    EXIF_FILESOURCE = 41728, // 0x0000A300

    /// <summary>Scene type.</summary>
    EXIF_SCENETYPE = 41729, // 0x0000A301

    /// <summary>CFA pattern.</summary>
    EXIF_CFAPATTERN = 41730, // 0x0000A302

    /// <summary>Custom image processing.</summary>
    EXIF_CUSTOMRENDERED = 41985, // 0x0000A401

    /// <summary>Exposure mode.</summary>
    EXIF_EXPOSUREMODE = 41986, // 0x0000A402

    /// <summary>White balance.</summary>
    EXIF_WHITEBALANCE = 41987, // 0x0000A403

    /// <summary>Digital zoom ratio.</summary>
    EXIF_DIGITALZOOMRATIO = 41988, // 0x0000A404

    /// <summary>Focal length in 35 mm film.</summary>
    EXIF_FOCALLENGTHIN35MMFILM = 41989, // 0x0000A405

    /// <summary>Scene capture type.</summary>
    EXIF_SCENECAPTURETYPE = 41990, // 0x0000A406

    /// <summary>Gain control.</summary>
    EXIF_GAINCONTROL = 41991, // 0x0000A407

    /// <summary>Contrast.</summary>
    EXIF_CONTRAST = 41992, // 0x0000A408

    /// <summary>Saturation.</summary>
    EXIF_SATURATION = 41993, // 0x0000A409

    /// <summary>Sharpness.</summary>
    EXIF_SHARPNESS = 41994, // 0x0000A40A

    /// <summary>Device settings description.</summary>
    EXIF_DEVICESETTINGDESCRIPTION = 41995, // 0x0000A40B

    /// <summary>Subject distance range.</summary>
    EXIF_SUBJECTDISTANCERANGE = 41996, // 0x0000A40C

    /// <summary>Unique image ID.</summary>
    EXIF_IMAGEUNIQUEID = 42016, // 0x0000A420

    /// <summary>
    /// This tag is used to store the band nodata value. Used in interchangeable GeoTIFF files.
    /// </summary>
    GDAL_NODATA = 42113, // 0x0000A481

    /// <summary>
    /// DNG version number. Introduced by Adobe DNG specification.
    /// </summary>
    DNGVERSION = 50706, // 0x0000C612

    /// <summary>
    /// DNG compatibility version. Introduced by Adobe DNG specification.
    /// </summary>
    DNGBACKWARDVERSION = 50707, // 0x0000C613

    /// <summary>
    /// Name for the camera model. Introduced by Adobe DNG specification.
    /// </summary>
    UNIQUECAMERAMODEL = 50708, // 0x0000C614

    /// <summary>
    /// Localized camera model name. Introduced by Adobe DNG specification.
    /// </summary>
    LOCALIZEDCAMERAMODEL = 50709, // 0x0000C615

    /// <summary>
    /// CFAPattern-&gt;LinearRaw space mapping. Introduced by Adobe DNG specification.
    /// </summary>
    CFAPLANECOLOR = 50710, // 0x0000C616

    /// <summary>
    /// Spatial layout of the CFA. Introduced by Adobe DNG specification.
    /// </summary>
    CFALAYOUT = 50711, // 0x0000C617

    /// <summary>
    /// Lookup table description. Introduced by Adobe DNG specification.
    /// </summary>
    LINEARIZATIONTABLE = 50712, // 0x0000C618

    /// <summary>
    /// Repeat pattern size for the BlackLevel tag. Introduced by Adobe DNG specification.
    /// </summary>
    BLACKLEVELREPEATDIM = 50713, // 0x0000C619

    /// <summary>
    /// Zero light encoding level. Introduced by Adobe DNG specification.
    /// </summary>
    BLACKLEVEL = 50714, // 0x0000C61A

    /// <summary>
    /// Zero light encoding level differences (columns). Introduced by Adobe DNG specification.
    /// </summary>
    BLACKLEVELDELTAH = 50715, // 0x0000C61B

    /// <summary>
    /// Zero light encoding level differences (rows). Introduced by Adobe DNG specification.
    /// </summary>
    BLACKLEVELDELTAV = 50716, // 0x0000C61C

    /// <summary>
    /// Fully saturated encoding level. Introduced by Adobe DNG specification.
    /// </summary>
    WHITELEVEL = 50717, // 0x0000C61D

    /// <summary>
    /// Default scale factors. Introduced by Adobe DNG specification.
    /// </summary>
    DEFAULTSCALE = 50718, // 0x0000C61E

    /// <summary>
    /// Origin of the final image area. Introduced by Adobe DNG specification.
    /// </summary>
    DEFAULTCROPORIGIN = 50719, // 0x0000C61F

    /// <summary>
    /// Size of the final image area. Introduced by Adobe DNG specification.
    /// </summary>
    DEFAULTCROPSIZE = 50720, // 0x0000C620

    /// <summary>
    /// XYZ-&gt;reference color space transformation matrix 1.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    COLORMATRIX1 = 50721, // 0x0000C621

    /// <summary>
    /// XYZ-&gt;reference color space transformation matrix 2.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    COLORMATRIX2 = 50722, // 0x0000C622

    /// <summary>
    /// Calibration matrix 1. Introduced by Adobe DNG specification.
    /// </summary>
    CAMERACALIBRATION1 = 50723, // 0x0000C623

    /// <summary>
    /// Calibration matrix 2. Introduced by Adobe DNG specification.
    /// </summary>
    CAMERACALIBRATION2 = 50724, // 0x0000C624

    /// <summary>
    /// Dimensionality reduction matrix 1. Introduced by Adobe DNG specification.
    /// </summary>
    REDUCTIONMATRIX1 = 50725, // 0x0000C625

    /// <summary>
    /// Dimensionality reduction matrix 2. Introduced by Adobe DNG specification.
    /// </summary>
    REDUCTIONMATRIX2 = 50726, // 0x0000C626

    /// <summary>
    /// Gain applied the stored raw values. Introduced by Adobe DNG specification.
    /// </summary>
    ANALOGBALANCE = 50727, // 0x0000C627

    /// <summary>
    /// Selected white balance in linear reference space.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    ASSHOTNEUTRAL = 50728, // 0x0000C628

    /// <summary>
    /// Selected white balance in x-y chromaticity coordinates.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    ASSHOTWHITEXY = 50729, // 0x0000C629

    /// <summary>
    /// How much to move the zero point. Introduced by Adobe DNG specification.
    /// </summary>
    BASELINEEXPOSURE = 50730, // 0x0000C62A

    /// <summary>
    /// Relative noise level. Introduced by Adobe DNG specification.
    /// </summary>
    BASELINENOISE = 50731, // 0x0000C62B

    /// <summary>
    /// Relative amount of sharpening. Introduced by Adobe DNG specification.
    /// </summary>
    BASELINESHARPNESS = 50732, // 0x0000C62C

    /// <summary>
    /// How closely the values of the green pixels in the blue/green rows
    /// track the values of the green pixels in the red/green rows.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    BAYERGREENSPLIT = 50733, // 0x0000C62D

    /// <summary>
    /// Non-linear encoding range. Introduced by Adobe DNG specification.
    /// </summary>
    LINEARRESPONSELIMIT = 50734, // 0x0000C62E

    /// <summary>
    /// Camera's serial number. Introduced by Adobe DNG specification.
    /// </summary>
    CAMERASERIALNUMBER = 50735, // 0x0000C62F

    /// <summary>Information about the lens.</summary>
    LENSINFO = 50736, // 0x0000C630

    /// <summary>
    /// Chroma blur radius. Introduced by Adobe DNG specification.
    /// </summary>
    CHROMABLURRADIUS = 50737, // 0x0000C631

    /// <summary>
    /// Relative strength of the camera's anti-alias filter.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    ANTIALIASSTRENGTH = 50738, // 0x0000C632

    /// <summary>
    /// Used by Adobe Camera Raw. Introduced by Adobe DNG specification.
    /// </summary>
    SHADOWSCALE = 50739, // 0x0000C633

    /// <summary>
    /// Manufacturer's private data. Introduced by Adobe DNG specification.
    /// </summary>
    DNGPRIVATEDATA = 50740, // 0x0000C634

    /// <summary>
    /// Whether the EXIF MakerNote tag is safe to preserve along with the rest of the EXIF data.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    MAKERNOTESAFETY = 50741, // 0x0000C635

    /// <summary>Illuminant 1. Introduced by Adobe DNG specification.</summary>
    CALIBRATIONILLUMINANT1 = 50778, // 0x0000C65A

    /// <summary>Illuminant 2. Introduced by Adobe DNG specification.</summary>
    CALIBRATIONILLUMINANT2 = 50779, // 0x0000C65B

    /// <summary>
    /// Best quality multiplier. Introduced by Adobe DNG specification.
    /// </summary>
    BESTQUALITYSCALE = 50780, // 0x0000C65C

    /// <summary>
    /// Unique identifier for the raw image data. Introduced by Adobe DNG specification.
    /// </summary>
    RAWDATAUNIQUEID = 50781, // 0x0000C65D

    /// <summary>
    /// File name of the original raw file. Introduced by Adobe DNG specification.
    /// </summary>
    ORIGINALRAWFILENAME = 50827, // 0x0000C68B

    /// <summary>
    /// Contents of the original raw file. Introduced by Adobe DNG specification.
    /// </summary>
    ORIGINALRAWFILEDATA = 50828, // 0x0000C68C

    /// <summary>
    /// Active (non-masked) pixels of the sensor. Introduced by Adobe DNG specification.
    /// </summary>
    ACTIVEAREA = 50829, // 0x0000C68D

    /// <summary>
    /// List of coordinates of fully masked pixels. Introduced by Adobe DNG specification.
    /// </summary>
    MASKEDAREAS = 50830, // 0x0000C68E

    /// <summary>
    /// Used to map cameras's color space into ICC profile space.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    ASSHOTICCPROFILE = 50831, // 0x0000C68F

    /// <summary>
    /// Used to map cameras's color space into ICC profile space.
    /// Introduced by Adobe DNG specification.
    /// </summary>
    ASSHOTPREPROFILEMATRIX = 50832, // 0x0000C690

    /// <summary>Introduced by Adobe DNG specification.</summary>
    CURRENTICCPROFILE = 50833, // 0x0000C691

    /// <summary>Introduced by Adobe DNG specification.</summary>
    CURRENTPREPROFILEMATRIX = 50834, // 0x0000C692

    /// <summary>
    /// Undefined tag used by Eastman Kodak, hue shift correction data.
    /// </summary>
    DCSHUESHIFTVALUES = 65535, // 0x0000FFFF

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Group 3/4 format control.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.FaxMode" />.
    /// </summary>
    FAXMODE = 65536, // 0x00010000

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Compression quality level. Quality level is on the IJG 0-100 scale. Default value is 75.
    /// </summary>
    JPEGQUALITY = 65537, // 0x00010001

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Auto RGB&lt;=&gt;YCbCr convert.
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.JpegColorMode" />.
    /// </summary>
    JPEGCOLORMODE = 65538, // 0x00010002

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// For the list of possible values, see <see cref="T:BitMiracle.LibTiff.Classic.JpegTablesMode" />.
    /// Default is <see cref="F:BitMiracle.LibTiff.Classic.JpegTablesMode.QUANT" /> | <see cref="F:BitMiracle.LibTiff.Classic.JpegTablesMode.HUFF" />.
    /// </summary>
    JPEGTABLESMODE = 65539, // 0x00010003

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// G3/G4 fill function.
    /// </summary>
    FAXFILLFUNC = 65540, // 0x00010004

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// PixarLogCodec I/O data sz.
    /// </summary>
    PIXARLOGDATAFMT = 65549, // 0x0001000D

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Imager mode &amp; filter.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSIMAGERTYPE = 65550, // 0x0001000E

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Interpolation mode.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSINTERPMODE = 65551, // 0x0001000F

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Color balance values.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSBALANCEARRAY = 65552, // 0x00010010

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Color correction values.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSCORRECTMATRIX = 65553, // 0x00010011

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Gamma value.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSGAMMA = 65554, // 0x00010012

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Toe &amp; shoulder points.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSTOESHOULDERPTS = 65555, // 0x00010013

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Calibration file description.
    /// </summary>
    DCSCALIBRATIONFD = 65556, // 0x00010014

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Compression quality level.
    /// Quality level is on the ZLIB 1-9 scale. Default value is -1.
    /// </summary>
    ZIPQUALITY = 65557, // 0x00010015

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// PixarLog uses same scale.
    /// </summary>
    PIXARLOGQUALITY = 65558, // 0x00010016

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// Area of image to acquire.
    /// Allocated to Oceana Matrix (<a href="mailto:dev@oceana.com">dev@oceana.com</a>).
    /// </summary>
    DCSCLIPRECTANGLE = 65559, // 0x00010017

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// SGILog user data format.
    /// </summary>
    SGILOGDATAFMT = 65560, // 0x00010018

    /// <summary>
    /// [pseudo tag. not written to file]<br />
    /// SGILog data encoding control.
    /// </summary>
    SGILOGENCODE = 65561, // 0x00010019
}