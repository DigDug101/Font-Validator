using System;
using System.Diagnostics;
using OTFontFile;
namespace OTFontFileVal {
    public enum W {
        _FONT_W_OptimalOrder,
        _FONT_W_UnnecessaryTable,
        _FONT_W_MissingRecommendedTable,
        _DE_W_TableAlignment,
        _DE_W_PadBytesNotZero,
        _TEST_W_ErrorInAnotherTable,
        _TEST_W_OtherErrorsInTable,
        CFF_W_INDEXFirstOffset,
        cmap_W_AppleLogo,
        cmap_W_AppleLogo_NoMap,
        cmap_W_AppleMSSupport_A,
        cmap_W_AppleMSSupport_M,
        cmap_W_EuroGlyph_Mac,
        cmap_W_EuroGlyph_Uni,
        cmap_W_f12_EncID,
        cmap_W_UnicodePrivateUse,
        cmap_W_f14_NonPacked,
        DSIG_W_VerifySignature_Generic,
        gasp_W_AdjRangeIdenticalFlags,
        glyf_W_CompositeReservedBit,
        hdmx_W_Need_Newer_FreeType,
        head_W_created_0,
        head_W_created_unlikely,
        head_W_flags_bit4_1_hdmx,
        head_W_flags_bit4_1_LTSH,
        head_W_lowestRecPPEM_large,
        head_W_lowestRecPPEM_small,
        head_W_modified_0,
        head_W_modified_unlikely,
        head_W_unitsPerEM_LT64,
        head_W_unitsPerEm_Pow2,
        head_W_fontRevision,
        hhea_W_hmtx_invalid,
        hhea_W_LineGapPositive,
        hhea_W_LineGap_minGap,
        hhea_W_Ascender_usWinAscent,
        hhea_W_Descender_usWinDescent,
        hmtx_W_CheckMetrics_lsb_gt_adv,
        kern_W_Format0_SearchFields,
        loca_W_GlyfEntryLengthAlignment,
        loca_W_GlyfPartiallyUnreferenced,
        loca_W_GlyfEntryEmpty,
        LTSH_W_yPels_zero,
        LTSH_W_Need_Newer_FreeType,
        maxp_W_Calculation_Unclear,
        name_W_subfamily_style,
        name_W_VersionMismatch_MS_MAC,
        name_W_VersionMismatch_3_1_3_10,
        name_W_CopyrightInconsistent,
        name_W_DescriptionInconsistent,
        name_W_TrademarkInconsistent,
        OS_2_W_CodePageRangeBitClear,
        OS_2_W_CodePageRangeBitSet,
        OS_2_W_fsSelection_weight,
        OS_2_W_hmtx_invalid,
        OS_2_W_Panose_undefined,
        OS_2_W_Version_old,
        OS_2_W_yStrikeoutPosition_unlikely,
        OS_2_W_yStrikeoutSize_unlikely,
        OS_2_W_ySubscriptXSize_unlikely,
        OS_2_W_ySubscriptYOffset_LTZero,
        OS_2_W_ySubscriptYSize_unlikely,
        OS_2_W_ySuperscriptXSize_unlikely,
        OS_2_W_ySuperscriptYOffset_unlikely,
        OS_2_W_ySuperscriptYSize_unlikely,
        OS_2_W_WeightClass_PANOSE,
        OS_2_W_sTypoAscenderDescender_difference,
        post_W_italicAngle_unlikely,
        post_W_underlinePos_LT_descender,
        post_W_underlineThickness,
        post_W_Version_2_5,
        VDMX_W_CalcData,
        VDMX_W_Need_Newer_FreeType,
        SVG_W_version,
        SVG_W_offsetToSVGDocIndex_NonContiguous,
        SVG_W_reserved,
        SVG_W_numEntries,
        SVG_W_SVGDocIndex,
        _OTL_DeviceTable_W_StartSize,
        _OTL_DeviceTable_W_EndSize,
        _OTL_FeatureListTable_W_FeatureRecord_tag,
        _rast_W_APPLE_ONLY_INSTR,
        _rast_W_CALL_ZERO_LEN_FUNC,
        _rast_W_CALL_ZERO_LEN_UD_INSTR,
        _rast_W_DEBUG_FOUND,
        _rast_W_DELTAC_IN_GLYPH_PGM,
        _rast_W_HI_PT_LESS_THAN_LOW_PT,
        _rast_W_JMP_OFFSET_ZERO,
        _rast_W_LOOP_NOT_1_AT_END_OF_PGM,
        _rast_W_LOOPCALL_COUNT_LESS_THAN_ONE,
        _rast_W_MPS_ALWAYS_12_ON_WINDOWS,
        _rast_W_PF_VECTORS_AT_OR_NEAR_PERP,
        _rast_W_PT_NOT_TOUCHED,
        _rast_W_SANGW_OBSELETE,
        _rast_W_Need_Newer_FreeType,
    }
    public enum E {
        OS_2_A_CodePageNotInstalled,
        _rast_A_ExceptionUnhandled,
        _GEN_E_EOFError,
        _GEN_E_InvalidFontFile,
        _GEN_E_OffsetExceedsTableLength,
        _GEN_E_ReadError,
        _GEN_E_UserCanceled,
        _OFFSET_E_entrySelector,
        _OFFSET_E_InvalidSFNT,
        _OFFSET_E_numTables,
        _OFFSET_E_rangeShift,
        _OFFSET_E_searchRange,
        _FONT_E_MissingRequiredTable,
        _DE_E_ChecksumError,
        _DE_E_DuplicateTag,
        _DE_E_LengthZero,
        _DE_E_OffsetPastEOF,
        _DE_E_OffsetZero,
        _DE_E_OverlappingTable,
        _DE_E_TableEndPastEOF,
        _DE_E_TagName,
        _DE_E_TagsAscending,
        _DE_E_TagZero,
        _Table_E_DataOverlap,
        _Table_E_Exception,
        _Table_E_Invalid,
        _TEST_E_TableMissing,
        CFF_E_Header,
        CFF_E_MAININDEX_Enumeration,
        CFF_E_NameDICTSize,
        CFF_E_StructOverlap,
        CFF_E_DICTUnwind,
        CFF_E_PrivDICTUnwind,
        CFF_E_INDEXCount,
        CFF_E_CharStringsCount,
        CFF_E_Non_ASCII_String_or_Name,
        cmap_E_DuplicateSubtables,
        cmap_E_f0_length,
        cmap_E_f12_SortOrder,
        cmap_E_f12_StartCode_GT_EndCode,
        cmap_E_f4_EndCodeOrder,
        cmap_E_f4_entrySelector,
        cmap_E_f4_FinalEndCode,
        cmap_E_f4_idDeltaNeg,
        cmap_E_f4_idRangeOffset,
        cmap_E_f4_rangeShift,
        cmap_E_f4_reservedPad,
        cmap_E_f4_searchRange,
        cmap_E_f4_segCountX2,
        cmap_E_f4_StartCode_GT_EndCode,
        cmap_E_Mapping,
        cmap_E_SubtableLength_eot,
        cmap_E_SubtableLength_zero,
        cmap_E_SubtableOffset_eot,
        cmap_E_SubtableOffset_zero,
        cmap_E_SubtableOverlap,
        cmap_E_SubtableSortOrder,
        cmap_E_SubtableValidFormat,
        cmap_E_version,
        cmap_E_NonMacSubtableLanguage,
        cmap_E_f12_EndCode_GT_10FFFF,
        cmap_E_f14_VarSelector,
        cmap_E_f14_VarSelector_Order,
        cmap_E_f14_VarSelector_Duplicate,
        cmap_E_f14_CodePoint,
        cmap_E_f14_DefaultUVS_Sort,
        cmap_E_f14_LastCode_GT_FFFFFF,
        cmap_E_f14_NonDefaultUVS_Sort,
        cmap_E_f14_GlyphID_Range,
        cmap_E_f14_DefaultUVS_EOT,
        cmap_E_f14_NonDefaultUVS_EOT,
        name_E_NoFormat14,
        cmap_E_f14_NonDefaultUVS_TooSmall,
        cmap_E_f14_DefaultUVS_TooSmall,
        cmap_E_f14_OverlappingMaps,
        cvt_E_length_odd,
        DSIG_E_Formats,
        DSIG_E_Reserved,
        DSIG_E_VerifySignature,
        EBDT_E_version,
        EBDT_E_TableDependency,
        EBDT_E_GlyphImageData,
        EBLC_E_bitDepth,
        EBLC_E_indexSubTableArrayOffset,
        EBLC_E_version,
        EBLC_E_TableDependency,
        EBLC_E_BitmapSizeTableIndexOrder,
        EBLC_E_indexSubTables,
        EBLC_E_numSizes,
        EBSC_E_TableLength,
        EBSC_E_version,
        EBSC_E_TableDependency,
        EBSC_E_StrikeSizeNoEBLC,
        EBSC_E_StrikeSize,
        gasp_E_rangeGaspBehavior,
        gasp_E_Sentinel,
        gasp_E_SortOrder,
        gasp_E_Version,
        glyf_E_CompositeAmbigousTransform,
        glyf_E_ExceptionUnhandeled,
        glyf_E_UnableToStartValidation,
        hdmx_E_DeviceRecordPadBytes_nonzero,
        hdmx_E_DuplicateDeviceRecords,
        hdmx_E_Rasterizer,
        hdmx_E_SizeofDeviceRecord_alignment,
        hdmx_E_SizeofDeviceRecord_numGlyphs,
        hdmx_E_SortedOrder,
        hdmx_E_Version,
        hdmx_E_Widths,
        hdmx_E_TableLength,
        hdmx_E_NumDeviceRecords_neg,
        head_E_created_invalid,
        head_E_flags_bit14,
        head_E_flags_bit15,
        head_E_flags_bit4_0_hdmx,
        head_E_flags_bit4_0_LTSH,
        head_E_FontChecksum,
        head_E_fontDirectionHint,
        head_E_glyphDataFormat,
        head_E_indexToLocFormat_match,
        head_E_indexToLocFormat_range,
        head_E_lowestRecPPEM_zero,
        head_E_macStyleBold_subfamily,
        head_E_macStyleBold0_OS2,
        head_E_macStyleBold1_OS2,
        head_E_macStyleItal_subfamily,
        head_E_macStyleItal0_OS2,
        head_E_macStyleItal0_post,
        head_E_macStyleItal1_OS2,
        head_E_macStyleItal1_post,
        head_E_MagicNumber,
        head_E_modified_invalid,
        head_E_TableLength,
        head_E_TableVersion,
        head_E_unitsPerEM_GT16384,
        head_E_unitsPerEm_LT16,
        head_E_xMax_glyf,
        head_E_xMin_glyf,
        head_E_xMin_GT_xMax,
        head_E_yMax_glyf,
        head_E_yMin_glyf,
        head_E_yMin_GT_yMax,
        hhea_E_advanceWidthMax,
        hhea_E_metricDataFormat,
        hhea_E_minLeftSideBearing,
        hhea_E_minRightSideBearing,
        hhea_E_numberOfHMetrics,
        hhea_E_reserved1,
        hhea_E_reserved2,
        hhea_E_reserved3,
        hhea_E_reserved4,
        hhea_E_version,
        hhea_E_xMaxExtent,
        hhea_E_caretSlopeAngle_italicAngle,
        hhea_E_caretSlopeRunNonZero_italicAngle,
        hhea_E_caretSlopeRunZero_italicAngle,
        hhea_E_AscenderPositive,
        hhea_E_DescenderNegative,
        hmtx_E_TableSize,
        kern_E_Format0_entrySelector,
        kern_E_Format0_rangeShift,
        kern_E_Format0_searchRange,
        kern_E_NumSubTables,
        kern_E_ReservedCoverageBits,
        kern_E_SubtableFormats,
        kern_E_SubtableLength,
        kern_E_TableVersion,
        kern_E_SubTableExtendsPastEOT,
        kern_E_Format0_GlyphIDs,
        kern_E_Format0_Values,
        kern_E_Format0_GlyphIdInCmap,
        loca_E_Format,
        loca_E_NumEntries,
        loca_E_OffsetsIncreasing,
        loca_E_OffsetWithinGlyfRange,
        LTSH_E_numGlyphs,
        LTSH_E_Rasterizer,
        LTSH_E_TableLength,
        LTSH_E_version,
        LTSH_E_yPels,
        maxp_E_Calculation,
        maxp_E_LENGTH_0_5,
        maxp_E_LENGTH_1_0,
        maxp_E_NumGlyphsMatchLoca,
        maxp_E_VERSION_0_5_glyf,
        maxp_E_VERSION_0_5_NOCFF,
        maxp_E_VERSION_1_0_CFF,
        maxp_E_VERSION_1_0_NOglyf,
        maxp_E_VERSION_INVALID,
        name_E_FormatSelector,
        name_E_MSLanguageID,
        name_E_NameRecordsSorted,
        name_E_NoMacPlatform,
        name_E_NoMSPlatform,
        name_E_PlatformSpecificEncoding,
        name_E_Postscript_chars,
        name_E_Postscript_length,
        name_E_Postscript_missing,
        name_E_Postscript_unequal,
        name_E_ReservedNameID,
        name_E_StringsWithinTable,
        name_E_UnicodeLength,
        name_E_VersionStringFormat,
        name_E_VersionStringNotFound,
        name_E_sample,
        OS_2_E_fsSelection_subfamily,
        OS_2_E_fsSelection_undefbits,
        OS_2_E_fsTypeReserved,
        OS_2_E_Panose_bArmStyle,
        OS_2_E_Panose_bContrast,
        OS_2_E_Panose_bFamilyType,
        OS_2_E_Panose_bLetterform,
        OS_2_E_Panose_bMidline,
        OS_2_E_Panose_bProportion,
        OS_2_E_Panose_bSerifStyle,
        OS_2_E_Panose_bStrokeVariation,
        OS_2_E_Panose_bWeight,
        OS_2_E_Panose_bXHeight,
        OS_2_E_RangeBitSet,
        OS_2_E_reg_bold,
        OS_2_E_reg_ital,
        OS_2_E_ReservedBitSet_CodePage,
        OS_2_E_ReservedBitSet_Unicode,
        OS_2_E_sCapHeight,
        OS_2_E_sFamilyClass_classID_reserved,
        OS_2_E_sFamilyClass_ClassID_undefined,
        OS_2_E_sFamilyClass_subclassID_undefined,
        OS_2_E_SurrogatesBitClear,
        OS_2_E_SurrogatesBitSet,
        OS_2_E_sxHeight,
        OS_2_E_SymbolBitClear,
        OS_2_E_SymbolBitSet,
        OS_2_E_TableLength,
        OS_2_E_usBreakChar_notmapped,
        OS_2_E_usDefaultChar_notmapped,
        OS_2_E_usFirstCharIndex,
        OS_2_E_usLastCharIndex,
        OS_2_E_Version,
        OS_2_E_WeightClass,
        OS_2_E_WidthClass,
        OS_2_E_xAvgCharWidth,
        OS_2_E_Panose_FamilyTypeNotSymbol,
        OS_2_E_Panose_FamilyTypeSymbol,
        OS_2_E_Panose_SymbolAspectRatio,
        OS_2_E_Panose_SymbolWeight,
        OS_2_E_fsSelection_macStyle_bold,
        OS_2_E_fsSelection_macStyle_italic,
        OS_2_E_sTypoAscender_notpositive,
        OS_2_E_sTypoDescender_positive,
        OS_2_E_fsTypeExclusiveBits,
        OS_2_E_usMaxContext,
        PCLT_E_Bottom6,
        PCLT_E_Pitch,
        PCLT_E_Reserved,
        PCLT_E_StrokeWeight,
        PCLT_E_Style_Posture,
        PCLT_E_Style_Reserved,
        PCLT_E_Style_Structure,
        PCLT_E_Style_Width,
        PCLT_E_TableLength,
        PCLT_E_Top2,
        PCLT_E_Version,
        PCLT_E_WidthType,
        post_E_glyphNameIndex_range,
        post_E_InvalidTableLen,
        post_E_isFixedPitchNonzero_hmtx,
        post_E_isFixedPitchNonzero_OS_2,
        post_E_isFixedPitchZero_hmtx,
        post_E_isFixedPitchZero_OS_2,
        post_E_italicAngleNonzero_caretSlopeRun,
        post_E_italicAngleNonzero_hheaAngle,
        post_E_italicAngleNonzero_macStyle,
        post_E_italicAngleZero_caretSlopeRun,
        post_E_italicAngleZero_macStyle,
        post_E_TableLenNot32,
        post_E_v2_NameLengthInvalid,
        post_E_v2_NameOffsetInvalid,
        post_E_v2_numberOfGlyphs,
        post_E_Version,
        VDMX_E_CalcData,
        VDMX_E_GroupsInTable,
        VDMX_E_InvalidOffset,
        VDMX_E_Version,
        VDMX_E_yPelHeight_illegal,
        vhea_E_metricDataFormat,
        vhea_E_ReservedFields,
        vhea_E_version,
        vmtx_E_TableLength,
        VORG_E_CFF_Font,
        VORG_E_Version,
        SVG_E_offsetToSVGDocIndex_Overlapping,
        SVG_E_SVGDocIndex,
        SVG_E_TryLoadSVG,
        GDEF_E_AttachListTable_AttachPointArray_PastEOT,
        GDEF_E_AttachListTable_AttachPointOffset,
        GDEF_E_AttachListTable_CoverageOffset_0,
        GDEF_E_AttachListTable_CoverageOffset_invalid,
        GDEF_E_CaretValueTable_Format,
        GDEF_E_HeaderOffset,
        GDEF_E_LigCaretListTable_CoverageOffset_0,
        GDEF_E_LigCaretListTable_CoverageOffset_invalid,
        GDEF_E_LigCaretListTable_LigGlyphArray_PastEOT,
        GDEF_E_LigCaretListTable_LigGlyphOffset,
        GDEF_E_LigGlyphTable_CaretValueArray_PastEOT,
        GDEF_E_LigGlyphTable_CaretValueOffset,
        GDEF_E_Version,
        GDEF_E_MarkSetTableFormat,
        GDEF_E_MarkGlyphSetsDefTable_PastEOT,
        GPOS_E_AnchorTable_format,
        GPOS_E_Array_order,
        GPOS_E_Array_pastEOT,
        GPOS_E_ExtensionLookupType,
        GPOS_E_HeaderOffset,
        GPOS_E_HeaderOffset_0,
        GPOS_E_Offset_PastEOT,
        GPOS_E_PosLookupRecord_SequenceIndex,
        GPOS_E_SubtableFormat,
        GPOS_E_ValueArray_pastEOT,
        GPOS_E_ValueFormatReservedBits,
        GPOS_E_Version,
        GSUB_E_Array_pastEOT,
        GSUB_E_ExtensionLookupType,
        GSUB_E_HeaderOffset,
        GSUB_E_HeaderOffset_0,
        GSUB_E_Offset_PastEOT,
        GSUB_E_SubstLookupRecord_SequenceIndex,
        GSUB_E_SubtableFormat,
        GSUB_E_Version,
        BASE_E_AxisTable_BaseScriptListOffset,
        BASE_E_AxisTable_BaseScriptListOffset_null,
        BASE_E_AxisTable_BaseTagListOffset,
        BASE_E_BaseCoordTable_format,
        BASE_E_BaseLangSysRecord_offset,
        BASE_E_BaseLangSysRecord_offset0,
        BASE_E_BaseLangSysRecord_order,
        BASE_E_BaseScriptList_Offset,
        BASE_E_BaseScriptList_Order,
        BASE_E_BaseTagList_TagOrder,
        BASE_E_BaseTagList_TagValid,
        BASE_E_BaseValuesOffset,
        BASE_E_BaseValuesTable_BCO_0,
        BASE_E_BaseValuesTable_BCO_invalid,
        BASE_E_DefaultMinMaxOffset,
        BASE_E_FeatMinMaxRecords_MaxCO_offset,
        BASE_E_FeatMinMaxRecords_MinCO_offset,
        BASE_E_HorizAxisOffset_OutsideTable,
        BASE_E_MinMaxTable_MaxCO,
        BASE_E_MinMaxTable_MinCO,
        BASE_E_Version,
        BASE_E_VertAxisOffset_OutsideTable,
        JSTF_E_Array_order,
        JSTF_E_Array_pastEOT,
        JSTF_E_Offset_PastEOT,
        JSTF_E_tag,
        JSTF_E_Version,
        _OTL_ClassDefinitionTable_E_Format,
        _OTL_ClassDefinitionTable_E_GlyphArrayPastEOT,
        _OTL_ClassDefinitionTable_E_RangeRecordArray_order,
        _OTL_ClassDefinitionTable_E_RangeRecordArrayPastEOT,
        _OTL_CoverageTable_E_Format,
        _OTL_CoverageTable_E_GlyphArrayPastEOT,
        _OTL_CoverageTable_E_RangeRecordArrayPastEOT,
        _OTL_DeviceTable_E_DeltaFormat,
        _OTL_DeviceTable_E_DeltaValueArray_pastEOT,
        _OTL_DeviceTable_E_sizes,
        _OTL_FeatureListTable_E_FeatureRecord_offset,
        _OTL_FeatureListTable_E_FeatureRecord_tag,
        _OTL_FeatureListTable_E_FeatureRecordArray_order,
        _OTL_FeatureListTable_E_FeatureRecordArray_pastEOT,
        _OTL_FeatureTable_E_FeatureParams_nonnull,
        _OTL_FeatureTable_E_LookupListIndexArray_pastEOT,
        _OTL_LangSysTable_E_FeatureIndexArray_pastEOT,
        _OTL_LangSysTable_E_LookupOrder,
        _OTL_LookupListTable_E_Lookup_offset,
        _OTL_LookupListTable_E_LookupArray_pastEOT,
        _OTL_LookupTable_E_LookupFlag_reserved,
        _OTL_LookupTable_E_LookupType,
        _OTL_LookupTable_E_SubtableArray_offset,
        _OTL_LookupTable_E_SubtableArray_pastEOT,
        _OTL_ScriptListTable_E_ScriptRecord_offset,
        _OTL_ScriptListTable_E_ScriptRecord_tag,
        _OTL_ScriptListTable_E_ScriptRecordArray_order,
        _OTL_ScriptListTable_E_ScriptRecordArray_pastEOT,
        _OTL_ScriptTable_E_DefaultLangSysOffset,
        _OTL_ScriptTable_E_LangSysRecord_offset,
        _OTL_ScriptTable_E_LangSysRecord_tag,
        _OTL_ScriptTable_E_LangSysRecordArray_order,
        _OTL_ScriptTable_E_LangSysRecordArray_pastEOT,
        _rast_E_3_USED_FOR_PERIOD,
        _rast_E_BITS_10_AND_13_SET,
        _rast_E_BITS_8_AND_11_SET,
        _rast_E_BITS_9_AND_12_SET,
        _rast_E_CONTOUR_OUT_OF_RANGE,
        _rast_E_CVT_OUT_OF_RANGE,
        _rast_E_DIVIDE_BY_ZERO,
        _rast_E_EIF_WITHOUT_IF,
        _rast_E_ELSE_WITHOUT_EIF,
        _rast_E_ELSE_WITHOUT_IF,
        _rast_E_ENDF_BEYOND_64K_OF_FDEF,
        _rast_E_ENDF_BEYOND_64K_OF_IDEF,
        _rast_E_ENDF_EXECUTED,
        _rast_E_EXCEEDS_INSTR_DEFS_IN_MAXP,
        _rast_E_FDEF_FOUND_IN_FDEF,
        _rast_E_FDEF_FOUND_IN_IDEF,
        _rast_E_FDEF_OUT_OF_RANGE,
        _rast_E_FDEF_SPACE_NOT_DEFINED,
        _rast_E_FDEF_WITHOUT_ENDF,
        _rast_E_FUCOORDINATE_OUT_OF_RANGE,
        _rast_E_FUNCTION_NOT_DEFINED,
        _rast_E_IDEF_FOUND_IN_FDEF,
        _rast_E_IDEF_FOUND_IN_IDEF,
        _rast_E_IDEF_WITHOUT_ENDF,
        _rast_E_IF_WITHOUT_EIF,
        _rast_E_INST_OPCODE_TO_LARGE,
        _rast_E_INSTR_DEFD_BY_FS,
        _rast_E_INVALID_FLAG,
        _rast_E_INVALID_INSTRUCTION,
        _rast_E_INVALID_MAXZONES_IN_MAXP,
        _rast_E_INVALID_STACK_ACCESS,
        _rast_E_INVALID_ZONE,
        _rast_E_INVALID_ZONE_IN_IUP,
        _rast_E_INVALID_ZONE_NO_TWI,
        _rast_E_JMP_BEFORE_BEGINNING,
        _rast_E_JMP_BEYOND_2MORE_THAN_END,
        _rast_E_MATH_OVERFLOW,
        _rast_E_NOT_CALLED_FROM_PREPROGRAM,
        _rast_E_OVERFLOW_INST_PTR,
        _rast_E_POINT_OUT_OF_RANGE,
        _rast_E_PREPROGAM_ZONE_NOT_TWI,
        _rast_E_REFPOINT_USED_BUT_NOT_SET,
        _rast_E_RESERVED_BIT_SET,
        _rast_E_RP1_RP2_SAME_POS_ON_PROJ,
        _rast_E_SELECTOR_INVALID,
        _rast_E_STACK_OVERFLOW,
        _rast_E_STACK_UNDERFLOW,
        _rast_E_STORAGE_OUT_OF_RANGE,
        _rast_E_STORE_INDEX_NOT_WRITTEN_TO,
        _rast_E_TWILIGHT_ZONE_PT_NOT_SET,
        _rast_E_VALUE_INVALID_0_OR_1,
        _rast_E_VALUE_INVALID_0_OR_2,
        _rast_E_VALUE_OUT_OF_RANGE,
        _rast_E_VALUE_TO_LARGE_FOR_INT16,
        _rast_E_VALUE_TO_LARGE_FOR_INT8,
        _rast_E_VALUE_TO_SMALL,
        _rast_E_VECTOR_XY_INVALID,
        _rast_E_VECTOR_XY_ZERO,
        _rast_E_ZONE_NOT_0_NOR_1,
        _rast_E_rasterization,
    }
    public enum I {
        _GEN_I_Collection,
        _GEN_I_OpeningFile,
        _GEN_I_Single,
        _GEN_I_TotalValTime,
        _Table_I_Non_OT_Table,
        _Table_I_NotSelected,
        _TEST_I_NotForCFF,
        _TEST_I_TableVersion,
        _TEST_I_RastTestNotSelected,
        CFF_I_NotValidated,
        CFF_I_Version,
        CFF_I_CIDROS,
        DSIG_I_VerifySignature_Generic,
        fpgm_I_NotValidated,
        hhea_I_Ascender_yMax,
        hhea_I_Descender_yMin,
        loca_I_GlyfEntryEmpty,
        maxp_I_Calculation_Method1,
        maxp_I_Calculation_Method2,
        name_I_Preferred_family_present,
        name_I_Preferred_family_not_present,
        name_I_Preferred_subfamily_present,
        name_I_Preferred_subfamily_not_present,
        OS_2_I_RangeBitNotSet,
        post_I_names_noAdobe,
        post_I_names_nomatch,
        post_I_v2_glyphNameIndex_notv2,
        post_I_v2_names_notv2,
        post_I_v2_numberOfGlyphs_notv2,
        post_I_names_uni_unexpected,
        prep_I_NotValidated,
        GDEF_I_MarkSetCount,
        _rast_I_rasterization,
    }
    public enum P {
        _OFFSET_P_BinarySearchTables,
        _OFFSET_P_numTables,
        _FONT_P_MissingRequiredTable,
        _FONT_P_OptimalOrder,
        _FONT_P_UnnecessaryTable,
        _FONT_P_MissingRecommendedTable,
        _DE_P_TableAlignment,
        _DE_P_TagName,
        _DE_P_TagsAscending,
        CFF_P_Header,
        CFF_P_MAININDEX_Enumeration,
        CFF_P_NameDICTSize,
        CFF_P_DICTUnwind,
        CFF_P_PrivDICTUnwind,
        CFF_P_INDEXCount,
        CFF_P_CharStringsCount,
        CFF_P_Non_ASCII_String_or_Name,
        cmap_P_AppleLogo,
        cmap_P_AppleMSSupport,
        cmap_P_DuplicateSubtables,
        cmap_P_EuroGlyph_Mac,
        cmap_P_EuroGlyph_Uni,
        cmap_P_InternalFormat,
        cmap_P_SubtableLength,
        cmap_P_SubtableOffset,
        cmap_P_SubtableOverlap,
        cmap_P_SubtableSortOrder,
        cmap_P_SubtableValidFormat,
        cmap_P_UnicodePrivateUse,
        cmap_P_version,
        cmap_P_UnicodePrivateUse_lig,
        cmap_P_NonMacSubtableLanguage,
        cvt_P_length_even,
        DSIG_P_Formats,
        DSIG_P_Reserved,
        DSIG_P_VerifySignature,
        EBDT_P_version,
        EBDT_P_TableDependency,
        EBDT_P_GlyphImageData,
        EBLC_P_bitDepth,
        EBLC_P_indexSubTableArrayOffset,
        EBLC_P_version,
        EBLC_P_TableDependency,
        EBLC_P_BitmapSizeTableIndexOrder,
        EBLC_P_indexSubTables,
        EBLC_P_numSizes,
        EBSC_P_TableLength,
        EBSC_P_version,
        EBSC_P_TableDependency,
        EBSC_P_StrikeSize,
        gasp_P_rangeGaspBehavior,
        gasp_P_Sentinel,
        gasp_P_SortOrder,
        gasp_P_Version,
        gasp_P_AdjRangeIdenticalFlags,
        hdmx_P_DeviceRecordPadBytes_none,
        hdmx_P_DeviceRecordPadBytes_zero,
        hdmx_P_DuplicateDeviceRecords,
        hdmx_P_SizeofDeviceRecord,
        hdmx_P_SortedOrder,
        hdmx_P_Version,
        hdmx_P_Widths,
        hdmx_P_TableLength,
        hdmx_P_NumDeviceRecords,
        head_P_created_0,
        head_P_flags_bit14,
        head_P_flags_bit15,
        head_P_flags_bit4_0_hdmx,
        head_P_flags_bit4_0_LTSH,
        head_P_flags_bit4_1_hdmx,
        head_P_flags_bit4_1_LTSH,
        head_P_FontChecksum,
        head_P_fontDirectionHint,
        head_P_glyphDataFormat,
        head_P_indexToLocFormat_ignore,
        head_P_indexToLocFormat_match,
        head_P_indexToLocFormat_range,
        head_P_lowestRecPPEM,
        head_P_macStyleBold_OS2,
        head_P_macStyleBold_subfamily,
        head_P_macStyleItal_OS2,
        head_P_macStyleItal_post,
        head_P_macStyleItal_subfamily,
        head_P_MagicNumber,
        head_P_modified_0,
        head_P_TableLength,
        head_P_TableVersion,
        head_P_unitsPerEm,
        head_P_xMax_glyf,
        head_P_xMin_glyf,
        head_P_yMax_glyf,
        head_P_yMin_glyf,
        head_P_fontRevision,
        hhea_P_advanceWidthMax,
        hhea_P_metricDataFormat,
        hhea_P_minLeftSideBearing,
        hhea_P_minRightSideBearing,
        hhea_P_numberOfHMetrics,
        hhea_P_reserved,
        hhea_P_version,
        hhea_P_xMaxExtent,
        hhea_P_caretSlopeAngle_italicAngle,
        hhea_P_AscenderPositive,
        hhea_P_Ascender_yMax,
        hhea_P_DescenderNegative,
        hhea_P_Descender_yMin,
        hhea_P_LineGapPositive,
        hhea_P_LineGap_minGap,
        hhea_P_Ascender_usWinAscent,
        hhea_P_Descender_usWinDescent,
        hmtx_P_CheckMetrics,
        hmtx_P_TableSize,
        kern_P_Format0_SearchFields,
        kern_P_NumSubTables,
        kern_P_ReservedCoverageBits,
        kern_P_SubtableFormats,
        kern_P_SubtableLengths,
        kern_P_TableVersion,
        kern_P_Format0_GlyphIDs,
        kern_P_Format0_Values,
        kern_P_Format0_GlyphIdInCmap,
        loca_P_Format,
        loca_P_GlyfEntryEmpty,
        loca_P_GlyfEntryLengthAlignment,
        loca_P_GlyfPartiallyUnreferenced,
        loca_P_NumEntries,
        loca_P_OffsetsIncreasing,
        loca_P_OffsetWithinGlyfRange,
        LTSH_P_numGlyphs,
        LTSH_P_TableLength,
        LTSH_P_version,
        LTSH_P_yPels,
        maxp_P_Calculation,
        maxp_P_LENGTH_0_5,
        maxp_P_LENGTH_1_0,
        maxp_P_NumGlyphsMatchLoca,
        maxp_P_VERSION_0_5,
        maxp_P_VERSION_1_0,
        name_P_BothPlatforms,
        name_P_FormatSelector,
        name_P_MSLanguageID,
        name_P_NameRecordsSorted,
        name_P_PlatformSpecificEncoding,
        name_P_Postscript,
        name_P_ReservedNameID,
        name_P_StringsWithinTable,
        name_P_UnicodeLength,
        name_P_VersionStringFormat,
        name_P_subfamily,
        name_P_sample,
        name_P_CopyrightConsistent,
        name_P_DescriptionConsistent,
        name_P_TrademarkConsistent,
        name_P_NoFormat14,
        OS_2_P_CharIndexes,
        OS_2_P_CodePageRanges,
        OS_2_P_fsSelection,
        OS_2_P_fsType,
        OS_2_P_Panose,
        OS_2_P_sCapHeight_nonzero,
        OS_2_P_sCapHeight_zero,
        OS_2_P_sFamilyClass,
        OS_2_P_Strikeout,
        OS_2_P_SuperscriptSubscript,
        OS_2_P_sxHeight_nonzero,
        OS_2_P_sxHeight_zero,
        OS_2_P_TableLength,
        OS_2_P_UnicodeRanges,
        OS_2_P_usBreakChar_mapped,
        OS_2_P_usDefaultChar_nonzero,
        OS_2_P_usDefaultChar_zero,
        OS_2_P_Version,
        OS_2_P_WeightClass,
        OS_2_P_WidthClass,
        OS_2_P_xAvgCharWidth,
        OS_2_P_WeightClass_PANOSE,
        OS_2_P_sTypoAscenderDescender,
        OS_2_P_usMaxContext,
        PCLT_P_Pitch,
        PCLT_P_Reserved,
        PCLT_P_SerifStyle,
        PCLT_P_StrokeWeight,
        PCLT_P_Style,
        PCLT_P_TableLength,
        PCLT_P_Version,
        PCLT_P_WidthType,
        post_P_glyphNameIndex,
        post_P_isFixedPitch,
        post_P_italicAngle,
        post_P_names,
        post_P_TableLength,
        post_P_underlinePosition,
        post_P_underlineThickness,
        post_P_v2_numberOfGlyphs,
        post_P_Version,
        VDMX_P_CalcData,
        VDMX_P_GroupsInTable,
        VDMX_P_Offsets,
        VDMX_P_Version,
        vhea_P_metricDataFormat,
        vhea_P_ReservedFields,
        vhea_P_version,
        vmtx_P_TableLength,
        VORG_P_CFF_Font,
        VORG_P_Version,
        SVG_P_version,
        SVG_P_offsetToSVGDocIndex,
        SVG_P_reserved,
        SVG_P_numEntries,
        SVG_P_SVGDocIndex,
        SVG_P_TryLoadSVG,
        GDEF_P_AttachListTable_AttachPointArray,
        GDEF_P_AttachListTable_CoverageOffset,
        GDEF_P_HeaderOffsets,
        GDEF_P_LigCaretListTable_CoverageOffset,
        GDEF_P_LigCaretListTable_LigGlyphArray,
        GDEF_P_LigGlyphTable_CaretValueArray,
        GDEF_P_Version,
        GDEF_P_MarkGlyphSetsDefTable,
        GPOS_P_AnchorTable,
        GPOS_P_BaseArrayTable,
        GPOS_P_BaseRecord,
        GPOS_P_ChainContextPos,
        GPOS_P_ChainPosClassRule,
        GPOS_P_ChainPosClassSet,
        GPOS_P_ChainPosRule,
        GPOS_P_ChainPosRuleSet,
        GPOS_P_Class1Record,
        GPOS_P_Class2Record,
        GPOS_P_ComponentRecord,
        GPOS_P_ContextPos,
        GPOS_P_CursivePos,
        GPOS_P_EntryExit,
        GPOS_P_ExtensionPos,
        GPOS_P_HeaderOffsets,
        GPOS_P_LigatureArrayTable,
        GPOS_P_LigatureAttachTable,
        GPOS_P_Mark2ArrayTable,
        GPOS_P_Mark2Record,
        GPOS_P_MarkArrayTable,
        GPOS_P_MarkBasePos,
        GPOS_P_MarkLigPos,
        GPOS_P_MarkMarkPos,
        GPOS_P_PairPos,
        GPOS_P_PairSet,
        GPOS_P_PosClassSet,
        GPOS_P_PosRule,
        GPOS_P_PosRuleSet,
        GPOS_P_SinglePos,
        GPOS_P_ValueRecord,
        GPOS_P_Version,
        GSUB_P_AlternateSubst,
        GSUB_P_ChainContextSubst,
        GSUB_P_ContextSubst,
        GSUB_P_ExtensionSubst,
        GSUB_P_HeaderOffsets,
        GSUB_P_LigatureSubst,
        GSUB_P_MultipleSubst,
        GSUB_P_SingleSubst,
        GSUB_P_Version,
        GSUB_P_ReverseChainContextSubst,
        BASE_P_AxisTable_BaseScriptListOffset_valid,
        BASE_P_AxisTable_BaseTagListOffset_null,
        BASE_P_AxisTable_BaseTagListOffset_valid,
        BASE_P_BaseCoordTable_format,
        BASE_P_BaseLangSysRecord_offsets,
        BASE_P_BaseLangSysRecord_order,
        BASE_P_BaseScriptList_Offset,
        BASE_P_BaseScriptList_Order,
        BASE_P_BaseTagList_TagOrder,
        BASE_P_BaseTagList_TagValid,
        BASE_P_BaseValuesOffset,
        BASE_P_BaseValuesOffset_null,
        BASE_P_BaseValuesTable_BCO,
        BASE_P_DefaultMinMaxOffset,
        BASE_P_DefaultMinMaxOffset_null,
        BASE_P_FeatMinMaxRecords_offsets,
        BASE_P_HorizAxisOffset_null,
        BASE_P_HorizAxisOffset_valid,
        BASE_P_MinMaxTable_MaxCO,
        BASE_P_MinMaxTable_MaxCO_0,
        BASE_P_MinMaxTable_MinCO,
        BASE_P_MinMaxTable_MinCO_0,
        BASE_P_Version,
        BASE_P_VertAxisOffset_null,
        BASE_P_VertAxisOffset_valid,
        JSTF_P_Version,
        _OTL_ClassDefinitionTable_P_valid,
        _OTL_CoverageTable_P_valid,
        _OTL_DeviceTable_P_valid,
        _OTL_FeatureListTable_P_valid,
        _OTL_FeatureTable_P_valid,
        _OTL_LangSysTable_P_valid,
        _OTL_LookupListTable_P_valid,
        _OTL_LookupTable_P_valid,
        _OTL_ScriptListTable_P_valid,
        _OTL_ScriptTable_P_valid,
        _rast_P_rasterization,
    }
    public enum T {
        T_NULL,
        _OFFSET_sfntVersion,
        _OFFSET_numTables,
        _OFFSET_BinarySearchFields,
        _DE_TagsAscendingOrder,
        _DE_TagNames,
        _DE_TableAlignment,
        _FONT_RequiredTables,
        _FONT_UnnecessaryTables,
        _FONT_RecommendedTables,
        BASE_Version,
        BASE_HeaderOffsets,
        BASE_HorizAxisTable,
        BASE_VertAxisTable,
        CFF_Header,
        CFF_MAININDEX_Enumeration,
        CFF_NameDICTSize,
        CFF_INDEXFirstOffset,
        CFF_StructOverlap,
        CFF_DICTUnwind,
        CFF_PrivDICTUnwind,
        CFF_INDEXCount,
        CFF_CharStringsCount,
        CFF_CIDROS,
        CFF_Non_ASCII_String_or_Name,
        CFF_TestCoverage,
        cmap_Version,
        cmap_SubtableOffset,
        cmap_SubtableLength,
        cmap_SubtableSortOrder,
        cmap_DuplicateSubtables,
        cmap_SubtableOverlap,
        cmap_ValidFormat,
        cmap_SubtableInternalFormat,
        cmap_AppleMSSupport,
        cmap_AppleLogo,
        cmap_EuroGlyph,
        cmap_PrivateUse,
        cmap_NonMacSubtableLanguage,
        cvt_length,
        DSIG_Formats,
        DSIG_Reserved,
        DSIG_VerifySignature,
        EBDT_version,
        EBDT_GlyphImageData,
        EBLC_version,
        EBLC_indexSubTableArrayOffset,
        EBLC_bitDepth,
        EBLC_indexSubTables,
        EBSC_version,
        EBSC_TableLength,
        gasp_Version,
        gasp_rangeGaspBehavior,
        gasp_SortOrder,
        gasp_Sentinel,
        gasp_AdjRangeIdenticalFlags,
        GDEF_Version,
        GDEF_HeaderOffsets,
        GDEF_Subtables,
        GPOS_Version,
        GPOS_HeaderOffsets,
        GPOS_Subtables,
        GSUB_Version,
        GSUB_HeaderOffsets,
        GSUB_Subtables,
        hdmx_Version,
        hdmx_NumDeviceRecords,
        hdmx_SizeofDeviceRecord,
        hdmx_TableLength,
        hdmx_DeviceRecordPadBytesZero,
        hdmx_SortedOrder,
        hdmx_DuplicateDeviceRecords,
        hdmx_Widths,
        head_TableLength,
        head_TableVersion,
        head_fontRevision,
        head_ChecksumAdjustment,
        head_MagicNumber,
        head_FlagTests,
        head_UnitsPerEmValues,
        head_Dates,
        head_MinMaxValues,
        head_MacStyleBits,
        head_LowestRecSize,
        head_FontDirectionHint,
        head_IndexToLocFormat,
        head_GlyphDataFormat,
        hhea_version,
        hhea_MinMax,
        hhea_reserved,
        hhea_metricDataFormat,
        hhea_numberOfHMetrics,
        hhea_caretSlope,
        hmtx_TableSize,
        hmtx_CheckMetrics,
        JSTF_Version,
        JSTF_JstfScriptRecord_length,
        JSTF_JstfScriptRecord_order,
        JSTF_JstfScriptRecords,
        kern_TableVersion,
        kern_NumSubtables,
        kern_SubtableFormats,
        kern_SubtableLength,
        kern_CoverageReservedBits,
        kern_Format0_SearchFields,
        loca_NumEntries,
        loca_GlyfEntryLengthAlignment,
        loca_OffsetWithinGlyfRange,
        loca_OffsetsIncreasing,
        LTSH_version,
        LTSH_numGlyphs,
        LTSH_TableLength,
        LTSH_yPels,
        maxp_TableVersion,
        maxp_TableLength,
        maxp_NumGlyphsMatchLoca,
        maxp_GlyphStats,
        name_FormatSelector,
        name_StringsWithinTable,
        name_NameRecordsSorted,
        name_ReservedNameIDs,
        name_BothPlatforms,
        name_VersionString,
        name_PlatformSpecificEncoding,
        name_MSLanguageIDs,
        name_unicode_length,
        name_Postscript,
        name_Subfamily,
        name_NoFormat14,
        name_SampleString,
        name_PreferredFamily,
        name_PreferredSubfamily,
        OS_2_Version,
        OS_2_TableLength,
        OS_2_xAvgCharWidth,
        OS_2_WeightClass,
        OS_2_WidthClass,
        OS_2_fsType,
        OS_2_SubscriptSuperscript,
        OS_2_Strikeout,
        OS_2_FamilyClass,
        OS_2_Panose,
        OS_2_UnicodeRanges,
        OS_2_fsSelection,
        OS_2_CharIndexes,
        OS_2_TypoMetrics,
        OS_2_CodePageRanges,
        OS_2_sxHeight,
        OS_2_sCapHeight,
        OS_2_usDefaultChar,
        OS_2_usBreakChar,
        OS_2_maxContext,
        PCLT_TableLength,
        PCLT_Version,
        PCLT_Pitch,
        PCLT_Style,
        PCLT_StrokeWeight,
        PCLT_WidthType,
        PCLT_SerifStyle,
        PCLT_Reserved,
        post_TableLength,
        post_Version,
        post_italicAngle,
        post_underlinePosition,
        post_underlineThickness,
        post_isFixedPitch,
        post_v2_numberOfGlyphs,
        post_v2_glyphNameIndex,
        post_v2_names,
        SVG_version,
        SVG_offsetToSVGDocIndex,
        SVG_reserved,
        SVG_numEntries,
        SVG_SVGDocIndex,
        SVG_TryLoadSVG,
        VDMX_Version,
        VDMX_Offsets,
        VDMX_GroupsInTable,
        VDMX_CompareToCalcData,
        vhea_version,
        vhea_ReservedFields,
        vhea_metricDataFormat,
        vmtx_TableLength,
        VORG_CFF_Font,
        VORG_Version,
        loca_Format,
        loca_GlyfEntryEmpty,
        loca_GlyfPartiallyUnreferenced,
        glyf_ValidateAll,
        _FONT_OptimalTableOrder,
        hhea_AscenderPositive,
        hhea_DescenderNegative,
        hhea_LineGapPositive,
        hhea_Ascender_yMax,
        hhea_Descender_yMin,
        hhea_LineGap_minGap,
        hhea_Ascender_usWinAscent,
        hhea_Descender_usWinDescent,
        EBDT_TableDependency,
        EBLC_TableDependency,
        EBSC_TableDependency,
        EBLC_SizeTableIndexOrder,
        kern_Format0_GlyphIDs,
        kern_Format0_Values,
        EBLC_numSizes,
        kern_ids_in_cmap,
        name_CopyrightConsistent,
        name_TrademarkConsistent,
        name_DescriptionConsistent,
        cmap_SubtableLanguage,
        kern_Format0_IDsInCmap,
        EBSC_StrikeSizes,
        OS_2_usMaxContext,
    }
}
