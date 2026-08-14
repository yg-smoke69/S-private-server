using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D50")]
internal class AkSoundEnginePINVOKE
{
	[Token(Token = "0x60189D6")]
	[Address(RVA = "0x46B6784", Offset = "0x46B6784", VA = "0x46B6784")]
	static AkSoundEnginePINVOKE()
	{
	}

	[Token(Token = "0x60189D7")]
	[Address(RVA = "0x46B6788", Offset = "0x46B6788", VA = "0x46B6788")]
	public AkSoundEnginePINVOKE()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60189D8")]
	[Address(RVA = "0x46B6790", Offset = "0x46B6790", VA = "0x46B6790")]
	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get();

	[PreserveSig]
	[Token(Token = "0x60189D9")]
	[Address(RVA = "0x46B6868", Offset = "0x46B6868", VA = "0x46B6868")]
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60189DA")]
	[Address(RVA = "0x46B6960", Offset = "0x46B6960", VA = "0x46B6960")]
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189DB")]
	[Address(RVA = "0x46B6A50", Offset = "0x46B6A50", VA = "0x46B6A50")]
	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60189DC")]
	[Address(RVA = "0x46B6B48", Offset = "0x46B6B48", VA = "0x46B6B48")]
	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189DD")]
	[Address(RVA = "0x46B6C38", Offset = "0x46B6C38", VA = "0x46B6C38")]
	public static extern IntPtr CSharp_new_AkAudioSettings();

	[PreserveSig]
	[Token(Token = "0x60189DE")]
	[Address(RVA = "0x46B6D10", Offset = "0x46B6D10", VA = "0x46B6D10")]
	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189DF")]
	[Address(RVA = "0x46B6DF0", Offset = "0x46B6DF0", VA = "0x46B6DF0")]
	public static extern void CSharp_AkVector_Zero(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E0")]
	[Address(RVA = "0x46B6F00", Offset = "0x46B6F00", VA = "0x46B6F00")]
	public static extern void CSharp_AkVector_X_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x60189E1")]
	[Address(RVA = "0x46B7018", Offset = "0x46B7018", VA = "0x46B7018")]
	public static extern float CSharp_AkVector_X_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E2")]
	[Address(RVA = "0x46B7128", Offset = "0x46B7128", VA = "0x46B7128")]
	public static extern void CSharp_AkVector_Y_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x60189E3")]
	[Address(RVA = "0x46B7240", Offset = "0x46B7240", VA = "0x46B7240")]
	public static extern float CSharp_AkVector_Y_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E4")]
	[Address(RVA = "0x46B7350", Offset = "0x46B7350", VA = "0x46B7350")]
	public static extern void CSharp_AkVector_Z_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x60189E5")]
	[Address(RVA = "0x46B7468", Offset = "0x46B7468", VA = "0x46B7468")]
	public static extern float CSharp_AkVector_Z_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E6")]
	[Address(RVA = "0x46B7578", Offset = "0x46B7578", VA = "0x46B7578")]
	public static extern IntPtr CSharp_new_AkVector();

	[PreserveSig]
	[Token(Token = "0x60189E7")]
	[Address(RVA = "0x46B7678", Offset = "0x46B7678", VA = "0x46B7678")]
	public static extern void CSharp_delete_AkVector(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E8")]
	[Address(RVA = "0x46B7790", Offset = "0x46B7790", VA = "0x46B7790")]
	public static extern IntPtr CSharp_AkTransform_Position(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189E9")]
	[Address(RVA = "0x46B7870", Offset = "0x46B7870", VA = "0x46B7870")]
	public static extern IntPtr CSharp_AkTransform_OrientationFront(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189EA")]
	[Address(RVA = "0x46B7958", Offset = "0x46B7958", VA = "0x46B7958")]
	public static extern IntPtr CSharp_AkTransform_OrientationTop(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189EB")]
	[Address(RVA = "0x46B7A40", Offset = "0x46B7A40", VA = "0x46B7A40")]
	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x60189EC")]
	[Address(RVA = "0x46B7B38", Offset = "0x46B7B38", VA = "0x46B7B38")]
	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);

	[PreserveSig]
	[Token(Token = "0x60189ED")]
	[Address(RVA = "0x46B7C60", Offset = "0x46B7C60", VA = "0x46B7C60")]
	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60189EE")]
	[Address(RVA = "0x46B7D50", Offset = "0x46B7D50", VA = "0x46B7D50")]
	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4);

	[PreserveSig]
	[Token(Token = "0x60189EF")]
	[Address(RVA = "0x46B7E50", Offset = "0x46B7E50", VA = "0x46B7E50")]
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60189F0")]
	[Address(RVA = "0x46B7F50", Offset = "0x46B7F50", VA = "0x46B7F50")]
	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

	[PreserveSig]
	[Token(Token = "0x60189F1")]
	[Address(RVA = "0x46B8070", Offset = "0x46B8070", VA = "0x46B8070")]
	public static extern IntPtr CSharp_new_AkTransform();

	[PreserveSig]
	[Token(Token = "0x60189F2")]
	[Address(RVA = "0x46B8178", Offset = "0x46B8178", VA = "0x46B8178")]
	public static extern void CSharp_delete_AkTransform(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189F3")]
	[Address(RVA = "0x46B8290", Offset = "0x46B8290", VA = "0x46B8290")]
	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x60189F4")]
	[Address(RVA = "0x46B8390", Offset = "0x46B8390", VA = "0x46B8390")]
	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189F5")]
	[Address(RVA = "0x46B8488", Offset = "0x46B8488", VA = "0x46B8488")]
	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x60189F6")]
	[Address(RVA = "0x46B8588", Offset = "0x46B8588", VA = "0x46B8588")]
	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189F7")]
	[Address(RVA = "0x46B8680", Offset = "0x46B8680", VA = "0x46B8680")]
	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189F8")]
	[Address(RVA = "0x46B8770", Offset = "0x46B8770", VA = "0x46B8770")]
	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x60189F9")]
	[Address(RVA = "0x46B8858", Offset = "0x46B8858", VA = "0x46B8858")]
	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60189FA")]
	[Address(RVA = "0x46B8950", Offset = "0x46B8950", VA = "0x46B8950")]
	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues();

	[PreserveSig]
	[Token(Token = "0x60189FB")]
	[Address(RVA = "0x46B8A30", Offset = "0x46B8A30", VA = "0x46B8A30")]
	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189FC")]
	[Address(RVA = "0x46B8B20", Offset = "0x46B8B20", VA = "0x46B8B20")]
	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60189FD")]
	[Address(RVA = "0x46B8C10", Offset = "0x46B8C10", VA = "0x46B8C10")]
	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60189FE")]
	[Address(RVA = "0x46B8CF8", Offset = "0x46B8CF8", VA = "0x46B8CF8")]
	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60189FF")]
	[Address(RVA = "0x46B8DF0", Offset = "0x46B8DF0", VA = "0x46B8DF0")]
	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A00")]
	[Address(RVA = "0x46B8EE0", Offset = "0x46B8EE0", VA = "0x46B8EE0")]
	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A01")]
	[Address(RVA = "0x46B8FC0", Offset = "0x46B8FC0", VA = "0x46B8FC0")]
	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A02")]
	[Address(RVA = "0x46B90B8", Offset = "0x46B90B8", VA = "0x46B90B8")]
	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A03")]
	[Address(RVA = "0x46B91A0", Offset = "0x46B91A0", VA = "0x46B91A0")]
	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A04")]
	[Address(RVA = "0x46B9290", Offset = "0x46B9290", VA = "0x46B9290")]
	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A05")]
	[Address(RVA = "0x46B9378", Offset = "0x46B9378", VA = "0x46B9378")]
	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A06")]
	[Address(RVA = "0x46B9468", Offset = "0x46B9468", VA = "0x46B9468")]
	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A07")]
	[Address(RVA = "0x46B9550", Offset = "0x46B9550", VA = "0x46B9550")]
	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4);

	[PreserveSig]
	[Token(Token = "0x6018A08")]
	[Address(RVA = "0x46B9688", Offset = "0x46B9688", VA = "0x46B9688")]
	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A09")]
	[Address(RVA = "0x46B9788", Offset = "0x46B9788", VA = "0x46B9788")]
	public static extern int CSharp_AkAuxSendValue_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018A0A")]
	[Address(RVA = "0x46B9860", Offset = "0x46B9860", VA = "0x46B9860")]
	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A0B")]
	[Address(RVA = "0x46B9940", Offset = "0x46B9940", VA = "0x46B9940")]
	public static extern IntPtr CSharp_new_AkRamp__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018A0C")]
	[Address(RVA = "0x46B9A48", Offset = "0x46B9A48", VA = "0x46B9A48")]
	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A0D")]
	[Address(RVA = "0x46B9B68", Offset = "0x46B9B68", VA = "0x46B9B68")]
	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A0E")]
	[Address(RVA = "0x46B9C88", Offset = "0x46B9C88", VA = "0x46B9C88")]
	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A0F")]
	[Address(RVA = "0x46B9DA0", Offset = "0x46B9DA0", VA = "0x46B9DA0")]
	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A10")]
	[Address(RVA = "0x46B9EC0", Offset = "0x46B9EC0", VA = "0x46B9EC0")]
	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A11")]
	[Address(RVA = "0x46B9FD8", Offset = "0x46B9FD8", VA = "0x46B9FD8")]
	public static extern void CSharp_delete_AkRamp(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A12")]
	[Address(RVA = "0x46BA0E8", Offset = "0x46BA0E8", VA = "0x46BA0E8")]
	public static extern ushort CSharp_AK_INT_get();

	[PreserveSig]
	[Token(Token = "0x6018A13")]
	[Address(RVA = "0x46BA1E0", Offset = "0x46BA1E0", VA = "0x46BA1E0")]
	public static extern ushort CSharp_AK_FLOAT_get();

	[PreserveSig]
	[Token(Token = "0x6018A14")]
	[Address(RVA = "0x46BA2E0", Offset = "0x46BA2E0", VA = "0x46BA2E0")]
	public static extern byte CSharp_AK_INTERLEAVED_get();

	[PreserveSig]
	[Token(Token = "0x6018A15")]
	[Address(RVA = "0x46BA3E8", Offset = "0x46BA3E8", VA = "0x46BA3E8")]
	public static extern byte CSharp_AK_NONINTERLEAVED_get();

	[PreserveSig]
	[Token(Token = "0x6018A16")]
	[Address(RVA = "0x46BA4C0", Offset = "0x46BA4C0", VA = "0x46BA4C0")]
	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get();

	[PreserveSig]
	[Token(Token = "0x6018A17")]
	[Address(RVA = "0x46BA5A0", Offset = "0x46BA5A0", VA = "0x46BA5A0")]
	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get();

	[PreserveSig]
	[Token(Token = "0x6018A18")]
	[Address(RVA = "0x46BA680", Offset = "0x46BA680", VA = "0x46BA680")]
	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get();

	[PreserveSig]
	[Token(Token = "0x6018A19")]
	[Address(RVA = "0x46BA760", Offset = "0x46BA760", VA = "0x46BA760")]
	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A1A")]
	[Address(RVA = "0x46BA850", Offset = "0x46BA850", VA = "0x46BA850")]
	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A1B")]
	[Address(RVA = "0x46BA938", Offset = "0x46BA938", VA = "0x46BA938")]
	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A1C")]
	[Address(RVA = "0x46BAA28", Offset = "0x46BAA28", VA = "0x46BAA28")]
	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A1D")]
	[Address(RVA = "0x46BAB10", Offset = "0x46BAB10", VA = "0x46BAB10")]
	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A1E")]
	[Address(RVA = "0x46BAC00", Offset = "0x46BAC00", VA = "0x46BAC00")]
	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A1F")]
	[Address(RVA = "0x46BACE8", Offset = "0x46BACE8", VA = "0x46BACE8")]
	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A20")]
	[Address(RVA = "0x46BADD8", Offset = "0x46BADD8", VA = "0x46BADD8")]
	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A21")]
	[Address(RVA = "0x46BAEC0", Offset = "0x46BAEC0", VA = "0x46BAEC0")]
	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A22")]
	[Address(RVA = "0x46BAFB0", Offset = "0x46BAFB0", VA = "0x46BAFB0")]
	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A23")]
	[Address(RVA = "0x46BB098", Offset = "0x46BB098", VA = "0x46BB098")]
	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A24")]
	[Address(RVA = "0x46BB188", Offset = "0x46BB188", VA = "0x46BB188")]
	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A25")]
	[Address(RVA = "0x46BB270", Offset = "0x46BB270", VA = "0x46BB270")]
	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A26")]
	[Address(RVA = "0x46BB358", Offset = "0x46BB358", VA = "0x46BB358")]
	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A27")]
	[Address(RVA = "0x46BB440", Offset = "0x46BB440", VA = "0x46BB440")]
	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A28")]
	[Address(RVA = "0x46BB528", Offset = "0x46BB528", VA = "0x46BB528")]
	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A29")]
	[Address(RVA = "0x46BB608", Offset = "0x46BB608", VA = "0x46BB608")]
	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A2A")]
	[Address(RVA = "0x46BB6F0", Offset = "0x46BB6F0", VA = "0x46BB6F0")]
	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7);

	[PreserveSig]
	[Token(Token = "0x6018A2B")]
	[Address(RVA = "0x46BB800", Offset = "0x46BB800", VA = "0x46BB800")]
	public static extern bool CSharp_AkAudioFormat_IsChannelConfigSupported(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A2C")]
	[Address(RVA = "0x46BB8F8", Offset = "0x46BB8F8", VA = "0x46BB8F8")]
	public static extern IntPtr CSharp_new_AkAudioFormat();

	[PreserveSig]
	[Token(Token = "0x6018A2D")]
	[Address(RVA = "0x46BBA00", Offset = "0x46BBA00", VA = "0x46BBA00")]
	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A2E")]
	[Address(RVA = "0x46BBAE0", Offset = "0x46BBAE0", VA = "0x46BBAE0")]
	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A2F")]
	[Address(RVA = "0x46BBBC8", Offset = "0x46BBBC8", VA = "0x46BBBC8")]
	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A30")]
	[Address(RVA = "0x46BBCA8", Offset = "0x46BBCA8", VA = "0x46BBCA8")]
	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A31")]
	[Address(RVA = "0x46BBD88", Offset = "0x46BBD88", VA = "0x46BBD88")]
	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A32")]
	[Address(RVA = "0x46BBE68", Offset = "0x46BBE68", VA = "0x46BBE68")]
	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A33")]
	[Address(RVA = "0x46BBF80", Offset = "0x46BBF80", VA = "0x46BBF80")]
	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A34")]
	[Address(RVA = "0x46BC070", Offset = "0x46BC070", VA = "0x46BC070")]
	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A35")]
	[Address(RVA = "0x46BC168", Offset = "0x46BC168", VA = "0x46BC168")]
	public static extern IntPtr CSharp_new_AkIterator();

	[PreserveSig]
	[Token(Token = "0x6018A36")]
	[Address(RVA = "0x46BC268", Offset = "0x46BC268", VA = "0x46BC268")]
	public static extern void CSharp_delete_AkIterator(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A37")]
	[Address(RVA = "0x46BC380", Offset = "0x46BC380", VA = "0x46BC380")]
	public static extern int CSharp__ArrayPoolDefault_Get();

	[PreserveSig]
	[Token(Token = "0x6018A38")]
	[Address(RVA = "0x46BC458", Offset = "0x46BC458", VA = "0x46BC458")]
	public static extern IntPtr CSharp_new__ArrayPoolDefault();

	[PreserveSig]
	[Token(Token = "0x6018A39")]
	[Address(RVA = "0x46BC530", Offset = "0x46BC530", VA = "0x46BC530")]
	public static extern void CSharp_delete__ArrayPoolDefault(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A3A")]
	[Address(RVA = "0x46BC610", Offset = "0x46BC610", VA = "0x46BC610")]
	public static extern int CSharp__ArrayPoolLEngineDefault_Get();

	[PreserveSig]
	[Token(Token = "0x6018A3B")]
	[Address(RVA = "0x46BC6F0", Offset = "0x46BC6F0", VA = "0x46BC6F0")]
	public static extern IntPtr CSharp_new__ArrayPoolLEngineDefault();

	[PreserveSig]
	[Token(Token = "0x6018A3C")]
	[Address(RVA = "0x46BC7D0", Offset = "0x46BC7D0", VA = "0x46BC7D0")]
	public static extern void CSharp_delete__ArrayPoolLEngineDefault(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A3D")]
	[Address(RVA = "0x46BC8B8", Offset = "0x46BC8B8", VA = "0x46BC8B8")]
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018A3E")]
	[Address(RVA = "0x46BC998", Offset = "0x46BC998", VA = "0x46BC998")]
	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A3F")]
	[Address(RVA = "0x46BCA80", Offset = "0x46BCA80", VA = "0x46BCA80")]
	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A40")]
	[Address(RVA = "0x46BCB60", Offset = "0x46BCB60", VA = "0x46BCB60")]
	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A41")]
	[Address(RVA = "0x46BCC48", Offset = "0x46BCC48", VA = "0x46BCC48")]
	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A42")]
	[Address(RVA = "0x46BCD38", Offset = "0x46BCD38", VA = "0x46BCD38")]
	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A43")]
	[Address(RVA = "0x46BCE38", Offset = "0x46BCE38", VA = "0x46BCE38")]
	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A44")]
	[Address(RVA = "0x46BCF28", Offset = "0x46BCF28", VA = "0x46BCF28")]
	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A45")]
	[Address(RVA = "0x46BD010", Offset = "0x46BD010", VA = "0x46BD010")]
	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A46")]
	[Address(RVA = "0x46BD100", Offset = "0x46BD100", VA = "0x46BD100")]
	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A47")]
	[Address(RVA = "0x46BD1E8", Offset = "0x46BD1E8", VA = "0x46BD1E8")]
	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A48")]
	[Address(RVA = "0x46BD2D8", Offset = "0x46BD2D8", VA = "0x46BD2D8")]
	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A49")]
	[Address(RVA = "0x46BD3C0", Offset = "0x46BD3C0", VA = "0x46BD3C0")]
	public static extern IntPtr CSharp_new_AkPlaylistArray();

	[PreserveSig]
	[Token(Token = "0x6018A4A")]
	[Address(RVA = "0x46BD498", Offset = "0x46BD498", VA = "0x46BD498")]
	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A4B")]
	[Address(RVA = "0x46BD578", Offset = "0x46BD578", VA = "0x46BD578")]
	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A4C")]
	[Address(RVA = "0x46BD658", Offset = "0x46BD658", VA = "0x46BD658")]
	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A4D")]
	[Address(RVA = "0x46BD738", Offset = "0x46BD738", VA = "0x46BD738")]
	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A4E")]
	[Address(RVA = "0x46BD820", Offset = "0x46BD820", VA = "0x46BD820")]
	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A4F")]
	[Address(RVA = "0x46BD910", Offset = "0x46BD910", VA = "0x46BD910")]
	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A50")]
	[Address(RVA = "0x46BDA00", Offset = "0x46BDA00", VA = "0x46BDA00")]
	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A51")]
	[Address(RVA = "0x46BDAF0", Offset = "0x46BDAF0", VA = "0x46BDAF0")]
	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A52")]
	[Address(RVA = "0x46BDBD8", Offset = "0x46BDBD8", VA = "0x46BDBD8")]
	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A53")]
	[Address(RVA = "0x46BDCB8", Offset = "0x46BDCB8", VA = "0x46BDCB8")]
	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A54")]
	[Address(RVA = "0x46BDD98", Offset = "0x46BDD98", VA = "0x46BDD98")]
	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A55")]
	[Address(RVA = "0x46BDE78", Offset = "0x46BDE78", VA = "0x46BDE78")]
	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A56")]
	[Address(RVA = "0x46BDF58", Offset = "0x46BDF58", VA = "0x46BDF58")]
	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A57")]
	[Address(RVA = "0x46BE040", Offset = "0x46BE040", VA = "0x46BE040")]
	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A58")]
	[Address(RVA = "0x46BE128", Offset = "0x46BE128", VA = "0x46BE128")]
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A59")]
	[Address(RVA = "0x46BE210", Offset = "0x46BE210", VA = "0x46BE210")]
	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A5A")]
	[Address(RVA = "0x46BE300", Offset = "0x46BE300", VA = "0x46BE300")]
	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A5B")]
	[Address(RVA = "0x46BE3E0", Offset = "0x46BE3E0", VA = "0x46BE3E0")]
	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A5C")]
	[Address(RVA = "0x46BE4C8", Offset = "0x46BE4C8", VA = "0x46BE4C8")]
	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A5D")]
	[Address(RVA = "0x46BE5B0", Offset = "0x46BE5B0", VA = "0x46BE5B0")]
	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A5E")]
	[Address(RVA = "0x46BE6A0", Offset = "0x46BE6A0", VA = "0x46BE6A0")]
	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A5F")]
	[Address(RVA = "0x46BE788", Offset = "0x46BE788", VA = "0x46BE788")]
	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A60")]
	[Address(RVA = "0x46BE878", Offset = "0x46BE878", VA = "0x46BE878")]
	public static extern IntPtr CSharp_AkPlaylistArray_Insert(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A61")]
	[Address(RVA = "0x46BE960", Offset = "0x46BE960", VA = "0x46BE960")]
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A62")]
	[Address(RVA = "0x46BEA60", Offset = "0x46BEA60", VA = "0x46BEA60")]
	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A63")]
	[Address(RVA = "0x46BEB58", Offset = "0x46BEB58", VA = "0x46BEB58")]
	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A64")]
	[Address(RVA = "0x46BEC48", Offset = "0x46BEC48", VA = "0x46BEC48")]
	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A65")]
	[Address(RVA = "0x46BED30", Offset = "0x46BED30", VA = "0x46BED30")]
	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A66")]
	[Address(RVA = "0x46BEE18", Offset = "0x46BEE18", VA = "0x46BEE18")]
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6);

	[PreserveSig]
	[Token(Token = "0x6018A67")]
	[Address(RVA = "0x46BEF28", Offset = "0x46BEF28", VA = "0x46BEF28")]
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018A68")]
	[Address(RVA = "0x46BF030", Offset = "0x46BF030", VA = "0x46BF030")]
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018A69")]
	[Address(RVA = "0x46BF130", Offset = "0x46BF130", VA = "0x46BF130")]
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A6A")]
	[Address(RVA = "0x46BF228", Offset = "0x46BF228", VA = "0x46BF228")]
	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A6B")]
	[Address(RVA = "0x46BF318", Offset = "0x46BF318", VA = "0x46BF318")]
	public static extern IntPtr CSharp_new_AkPlaylist();

	[PreserveSig]
	[Token(Token = "0x6018A6C")]
	[Address(RVA = "0x46BF418", Offset = "0x46BF418", VA = "0x46BF418")]
	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A6D")]
	[Address(RVA = "0x46BF530", Offset = "0x46BF530", VA = "0x46BF530")]
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018A6E")]
	[Address(RVA = "0x46BF640", Offset = "0x46BF640", VA = "0x46BF640")]
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018A6F")]
	[Address(RVA = "0x46BF748", Offset = "0x46BF748", VA = "0x46BF748")]
	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A70")]
	[Address(RVA = "0x46BF838", Offset = "0x46BF838", VA = "0x46BF838")]
	public static extern int CSharp_DynamicSequenceClose(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A71")]
	[Address(RVA = "0x46BF918", Offset = "0x46BF918", VA = "0x46BF918")]
	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A72")]
	[Address(RVA = "0x46BFA10", Offset = "0x46BFA10", VA = "0x46BFA10")]
	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A73")]
	[Address(RVA = "0x46BFB00", Offset = "0x46BFB00", VA = "0x46BFB00")]
	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A74")]
	[Address(RVA = "0x46BFBE8", Offset = "0x46BFBE8", VA = "0x46BFBE8")]
	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A75")]
	[Address(RVA = "0x46BFCE0", Offset = "0x46BFCE0", VA = "0x46BFCE0")]
	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A76")]
	[Address(RVA = "0x46BFDD0", Offset = "0x46BFDD0", VA = "0x46BFDD0")]
	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A77")]
	[Address(RVA = "0x46BFEB8", Offset = "0x46BFEB8", VA = "0x46BFEB8")]
	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A78")]
	[Address(RVA = "0x46BFFB0", Offset = "0x46BFFB0", VA = "0x46BFFB0")]
	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A79")]
	[Address(RVA = "0x46C00A0", Offset = "0x46C00A0", VA = "0x46C00A0")]
	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A7A")]
	[Address(RVA = "0x46C0188", Offset = "0x46C0188", VA = "0x46C0188")]
	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A7B")]
	[Address(RVA = "0x46C0280", Offset = "0x46C0280", VA = "0x46C0280")]
	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A7C")]
	[Address(RVA = "0x46C0370", Offset = "0x46C0370", VA = "0x46C0370")]
	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A7D")]
	[Address(RVA = "0x46C0458", Offset = "0x46C0458", VA = "0x46C0458")]
	public static extern int CSharp_DynamicSequenceBreak(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A7E")]
	[Address(RVA = "0x46C0538", Offset = "0x46C0538", VA = "0x46C0538")]
	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A7F")]
	[Address(RVA = "0x46C0630", Offset = "0x46C0630", VA = "0x46C0630")]
	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A80")]
	[Address(RVA = "0x46C0718", Offset = "0x46C0718", VA = "0x46C0718")]
	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A81")]
	[Address(RVA = "0x46C0800", Offset = "0x46C0800", VA = "0x46C0800")]
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018A82")]
	[Address(RVA = "0x46C08E0", Offset = "0x46C08E0", VA = "0x46C08E0")]
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018A83")]
	[Address(RVA = "0x46C0A00", Offset = "0x46C0A00", VA = "0x46C0A00")]
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6018A84")]
	[Address(RVA = "0x46C0B18", Offset = "0x46C0B18", VA = "0x46C0B18")]
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A85")]
	[Address(RVA = "0x46C0C28", Offset = "0x46C0C28", VA = "0x46C0C28")]
	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A86")]
	[Address(RVA = "0x46C0D30", Offset = "0x46C0D30", VA = "0x46C0D30")]
	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A87")]
	[Address(RVA = "0x46C0E28", Offset = "0x46C0E28", VA = "0x46C0E28")]
	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A88")]
	[Address(RVA = "0x46C0F18", Offset = "0x46C0F18", VA = "0x46C0F18")]
	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A89")]
	[Address(RVA = "0x46C1008", Offset = "0x46C1008", VA = "0x46C1008")]
	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A8A")]
	[Address(RVA = "0x46C10F0", Offset = "0x46C10F0", VA = "0x46C10F0")]
	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A8B")]
	[Address(RVA = "0x46C11E8", Offset = "0x46C11E8", VA = "0x46C11E8")]
	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A8C")]
	[Address(RVA = "0x46C12D8", Offset = "0x46C12D8", VA = "0x46C12D8")]
	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A8D")]
	[Address(RVA = "0x46C13D0", Offset = "0x46C13D0", VA = "0x46C13D0")]
	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A8E")]
	[Address(RVA = "0x46C14C0", Offset = "0x46C14C0", VA = "0x46C14C0")]
	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A8F")]
	[Address(RVA = "0x46C15A0", Offset = "0x46C15A0", VA = "0x46C15A0")]
	public static extern void CSharp_AkTaskContext_uIdxThread_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A90")]
	[Address(RVA = "0x46C1690", Offset = "0x46C1690", VA = "0x46C1690")]
	public static extern uint CSharp_AkTaskContext_uIdxThread_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A91")]
	[Address(RVA = "0x46C1778", Offset = "0x46C1778", VA = "0x46C1778")]
	public static extern IntPtr CSharp_new_AkTaskContext();

	[PreserveSig]
	[Token(Token = "0x6018A92")]
	[Address(RVA = "0x46C1880", Offset = "0x46C1880", VA = "0x46C1880")]
	public static extern void CSharp_delete_AkTaskContext(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A93")]
	[Address(RVA = "0x46C1960", Offset = "0x46C1960", VA = "0x46C1960")]
	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A94")]
	[Address(RVA = "0x46C1A50", Offset = "0x46C1A50", VA = "0x46C1A50")]
	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A95")]
	[Address(RVA = "0x46C1B38", Offset = "0x46C1B38", VA = "0x46C1B38")]
	public static extern void CSharp_AkInitSettings_uDefaultPoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A96")]
	[Address(RVA = "0x46C1C30", Offset = "0x46C1C30", VA = "0x46C1C30")]
	public static extern uint CSharp_AkInitSettings_uDefaultPoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A97")]
	[Address(RVA = "0x46C1D20", Offset = "0x46C1D20", VA = "0x46C1D20")]
	public static extern void CSharp_AkInitSettings_fDefaultPoolRatioThreshold_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A98")]
	[Address(RVA = "0x46C1E20", Offset = "0x46C1E20", VA = "0x46C1E20")]
	public static extern float CSharp_AkInitSettings_fDefaultPoolRatioThreshold_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A99")]
	[Address(RVA = "0x46C1F18", Offset = "0x46C1F18", VA = "0x46C1F18")]
	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A9A")]
	[Address(RVA = "0x46C2010", Offset = "0x46C2010", VA = "0x46C2010")]
	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A9B")]
	[Address(RVA = "0x46C2100", Offset = "0x46C2100", VA = "0x46C2100")]
	public static extern void CSharp_AkInitSettings_uPrepareEventMemoryPoolID_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A9C")]
	[Address(RVA = "0x46C2200", Offset = "0x46C2200", VA = "0x46C2200")]
	public static extern int CSharp_AkInitSettings_uPrepareEventMemoryPoolID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A9D")]
	[Address(RVA = "0x46C22F8", Offset = "0x46C22F8", VA = "0x46C22F8")]
	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018A9E")]
	[Address(RVA = "0x46C23F8", Offset = "0x46C23F8", VA = "0x46C23F8")]
	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018A9F")]
	[Address(RVA = "0x46C24F8", Offset = "0x46C24F8", VA = "0x46C24F8")]
	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AA0")]
	[Address(RVA = "0x46C25F8", Offset = "0x46C25F8", VA = "0x46C25F8")]
	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AA1")]
	[Address(RVA = "0x46C26F0", Offset = "0x46C26F0", VA = "0x46C26F0")]
	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AA2")]
	[Address(RVA = "0x46C27E8", Offset = "0x46C27E8", VA = "0x46C27E8")]
	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AA3")]
	[Address(RVA = "0x46C28D8", Offset = "0x46C28D8", VA = "0x46C28D8")]
	public static extern void CSharp_AkInitSettings_uMonitorPoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AA4")]
	[Address(RVA = "0x46C29D0", Offset = "0x46C29D0", VA = "0x46C29D0")]
	public static extern uint CSharp_AkInitSettings_uMonitorPoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AA5")]
	[Address(RVA = "0x46C2AC0", Offset = "0x46C2AC0", VA = "0x46C2AC0")]
	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AA6")]
	[Address(RVA = "0x46C2BB8", Offset = "0x46C2BB8", VA = "0x46C2BB8")]
	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AA7")]
	[Address(RVA = "0x46C2CA8", Offset = "0x46C2CA8", VA = "0x46C2CA8")]
	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AA8")]
	[Address(RVA = "0x46C2DA0", Offset = "0x46C2DA0", VA = "0x46C2DA0")]
	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AA9")]
	[Address(RVA = "0x46C2E90", Offset = "0x46C2E90", VA = "0x46C2E90")]
	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AAA")]
	[Address(RVA = "0x46C2F88", Offset = "0x46C2F88", VA = "0x46C2F88")]
	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AAB")]
	[Address(RVA = "0x46C3078", Offset = "0x46C3078", VA = "0x46C3078")]
	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AAC")]
	[Address(RVA = "0x46C3178", Offset = "0x46C3178", VA = "0x46C3178")]
	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AAD")]
	[Address(RVA = "0x46C3278", Offset = "0x46C3278", VA = "0x46C3278")]
	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AAE")]
	[Address(RVA = "0x46C3370", Offset = "0x46C3370", VA = "0x46C3370")]
	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AAF")]
	[Address(RVA = "0x46C3468", Offset = "0x46C3468", VA = "0x46C3468")]
	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AB0")]
	[Address(RVA = "0x46C3578", Offset = "0x46C3578", VA = "0x46C3578")]
	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AB1")]
	[Address(RVA = "0x46C3668", Offset = "0x46C3668", VA = "0x46C3668")]
	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AB2")]
	[Address(RVA = "0x46C3758", Offset = "0x46C3758", VA = "0x46C3758")]
	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AB3")]
	[Address(RVA = "0x46C3840", Offset = "0x46C3840", VA = "0x46C3840")]
	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AB4")]
	[Address(RVA = "0x46C3938", Offset = "0x46C3938", VA = "0x46C3938")]
	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AB5")]
	[Address(RVA = "0x46C3A28", Offset = "0x46C3A28", VA = "0x46C3A28")]
	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AB6")]
	[Address(RVA = "0x46C3B28", Offset = "0x46C3B28", VA = "0x46C3B28")]
	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AB7")]
	[Address(RVA = "0x46C3C28", Offset = "0x46C3C28", VA = "0x46C3C28")]
	public static extern IntPtr CSharp_new_AkInitSettings();

	[PreserveSig]
	[Token(Token = "0x6018AB8")]
	[Address(RVA = "0x46C3D30", Offset = "0x46C3D30", VA = "0x46C3D30")]
	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AB9")]
	[Address(RVA = "0x46C3E10", Offset = "0x46C3E10", VA = "0x46C3E10")]
	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ABA")]
	[Address(RVA = "0x46C3F00", Offset = "0x46C3F00", VA = "0x46C3F00")]
	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018ABB")]
	[Address(RVA = "0x46C3FE8", Offset = "0x46C3FE8", VA = "0x46C3FE8")]
	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ABC")]
	[Address(RVA = "0x46C40E0", Offset = "0x46C40E0", VA = "0x46C40E0")]
	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018ABD")]
	[Address(RVA = "0x46C41D0", Offset = "0x46C41D0", VA = "0x46C41D0")]
	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ABE")]
	[Address(RVA = "0x46C42C0", Offset = "0x46C42C0", VA = "0x46C42C0")]
	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018ABF")]
	[Address(RVA = "0x46C43A8", Offset = "0x46C43A8", VA = "0x46C43A8")]
	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AC0")]
	[Address(RVA = "0x46C4488", Offset = "0x46C4488", VA = "0x46C4488")]
	public static extern int CSharp_AkSourceSettings_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018AC1")]
	[Address(RVA = "0x46C4568", Offset = "0x46C4568", VA = "0x46C4568")]
	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AC2")]
	[Address(RVA = "0x46C4650", Offset = "0x46C4650", VA = "0x46C4650")]
	public static extern IntPtr CSharp_new_AkSourceSettings();

	[PreserveSig]
	[Token(Token = "0x6018AC3")]
	[Address(RVA = "0x46C4728", Offset = "0x46C4728", VA = "0x46C4728")]
	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AC4")]
	[Address(RVA = "0x46C4808", Offset = "0x46C4808", VA = "0x46C4808")]
	public static extern bool CSharp_IsInitialized();

	[PreserveSig]
	[Token(Token = "0x6018AC5")]
	[Address(RVA = "0x46C4910", Offset = "0x46C4910", VA = "0x46C4910")]
	public static extern int CSharp_GetAudioSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AC6")]
	[Address(RVA = "0x46C4A28", Offset = "0x46C4A28", VA = "0x46C4A28")]
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AC7")]
	[Address(RVA = "0x46C4B18", Offset = "0x46C4B18", VA = "0x46C4B18")]
	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1();

	[PreserveSig]
	[Token(Token = "0x6018AC8")]
	[Address(RVA = "0x46C4BF8", Offset = "0x46C4BF8", VA = "0x46C4BF8")]
	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AC9")]
	[Address(RVA = "0x46C4CE8", Offset = "0x46C4CE8", VA = "0x46C4CE8")]
	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1);

	[PreserveSig]
	[Token(Token = "0x6018ACA")]
	[Address(RVA = "0x46C4DC8", Offset = "0x46C4DC8", VA = "0x46C4DC8")]
	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ACB")]
	[Address(RVA = "0x46C4EB8", Offset = "0x46C4EB8", VA = "0x46C4EB8")]
	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1);

	[PreserveSig]
	[Token(Token = "0x6018ACC")]
	[Address(RVA = "0x46C4F98", Offset = "0x46C4F98", VA = "0x46C4F98")]
	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In][Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4);

	[PreserveSig]
	[Token(Token = "0x6018ACD")]
	[Address(RVA = "0x46C50A0", Offset = "0x46C50A0", VA = "0x46C50A0")]
	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In][Out] float[] jarg1, ref uint jarg2, out float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018ACE")]
	[Address(RVA = "0x46C5198", Offset = "0x46C5198", VA = "0x46C5198")]
	public static extern int CSharp_SetSpeakerAngles__SWIG_0([In] float[] jarg1, uint jarg2, float jarg3, ulong jarg4);

	[PreserveSig]
	[Token(Token = "0x6018ACF")]
	[Address(RVA = "0x46C52A0", Offset = "0x46C52A0", VA = "0x46C52A0")]
	public static extern int CSharp_SetSpeakerAngles__SWIG_1([In] float[] jarg1, uint jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AD0")]
	[Address(RVA = "0x46C5398", Offset = "0x46C5398", VA = "0x46C5398")]
	public static extern int CSharp_SetVolumeThreshold(float jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AD1")]
	[Address(RVA = "0x46C54B0", Offset = "0x46C54B0", VA = "0x46C54B0")]
	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AD2")]
	[Address(RVA = "0x46C5590", Offset = "0x46C5590", VA = "0x46C5590")]
	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AD3")]
	[Address(RVA = "0x46C5670", Offset = "0x46C5670", VA = "0x46C5670")]
	public static extern int CSharp_RenderAudio__SWIG_1();

	[PreserveSig]
	[Token(Token = "0x6018AD4")]
	[Address(RVA = "0x46C5748", Offset = "0x46C5748", VA = "0x46C5748")]
	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AD5")]
	[Address(RVA = "0x46C5870", Offset = "0x46C5870", VA = "0x46C5870")]
	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AD6")]
	[Address(RVA = "0x46C5978", Offset = "0x46C5978", VA = "0x46C5978")]
	public static extern uint CSharp_GetIDFromString(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AD7")]
	[Address(RVA = "0x46C5AB0", Offset = "0x46C5AB0", VA = "0x46C5AB0")]
	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	[PreserveSig]
	[Token(Token = "0x6018AD8")]
	[Address(RVA = "0x46C5C00", Offset = "0x46C5C00", VA = "0x46C5C00")]
	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	[PreserveSig]
	[Token(Token = "0x6018AD9")]
	[Address(RVA = "0x46C5D50", Offset = "0x46C5D50", VA = "0x46C5D50")]
	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x6018ADA")]
	[Address(RVA = "0x46C5E90", Offset = "0x46C5E90", VA = "0x46C5E90")]
	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ADB")]
	[Address(RVA = "0x46C5FB8", Offset = "0x46C5FB8", VA = "0x46C5FB8")]
	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	[PreserveSig]
	[Token(Token = "0x6018ADC")]
	[Address(RVA = "0x46C6138", Offset = "0x46C6138", VA = "0x46C6138")]
	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	[PreserveSig]
	[Token(Token = "0x6018ADD")]
	[Address(RVA = "0x46C62A8", Offset = "0x46C62A8", VA = "0x46C62A8")]
	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x6018ADE")]
	[Address(RVA = "0x46C6408", Offset = "0x46C6408", VA = "0x46C6408")]
	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018ADF")]
	[Address(RVA = "0x46C6558", Offset = "0x46C6558", VA = "0x46C6558")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);

	[PreserveSig]
	[Token(Token = "0x6018AE0")]
	[Address(RVA = "0x46C6670", Offset = "0x46C6670", VA = "0x46C6670")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AE1")]
	[Address(RVA = "0x46C6780", Offset = "0x46C6780", VA = "0x46C6780")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AE2")]
	[Address(RVA = "0x46C6888", Offset = "0x46C6888", VA = "0x46C6888")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AE3")]
	[Address(RVA = "0x46C6988", Offset = "0x46C6988", VA = "0x46C6988")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AE4")]
	[Address(RVA = "0x46C6A78", Offset = "0x46C6A78", VA = "0x46C6A78")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);

	[PreserveSig]
	[Token(Token = "0x6018AE5")]
	[Address(RVA = "0x46C6BB0", Offset = "0x46C6BB0", VA = "0x46C6BB0")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AE6")]
	[Address(RVA = "0x46C6CE0", Offset = "0x46C6CE0", VA = "0x46C6CE0")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AE7")]
	[Address(RVA = "0x46C6E08", Offset = "0x46C6E08", VA = "0x46C6E08")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AE8")]
	[Address(RVA = "0x46C6F28", Offset = "0x46C6F28", VA = "0x46C6F28")]
	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AE9")]
	[Address(RVA = "0x46C7038", Offset = "0x46C7038", VA = "0x46C7038")]
	public static extern int CSharp_PostMIDIOnEvent(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AEA")]
	[Address(RVA = "0x46C7170", Offset = "0x46C7170", VA = "0x46C7170")]
	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018AEB")]
	[Address(RVA = "0x46C7260", Offset = "0x46C7260", VA = "0x46C7260")]
	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AEC")]
	[Address(RVA = "0x46C7340", Offset = "0x46C7340", VA = "0x46C7340")]
	public static extern int CSharp_StopMIDIOnEvent__SWIG_2();

	[PreserveSig]
	[Token(Token = "0x6018AED")]
	[Address(RVA = "0x46C7418", Offset = "0x46C7418", VA = "0x46C7418")]
	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AEE")]
	[Address(RVA = "0x46C7510", Offset = "0x46C7510", VA = "0x46C7510")]
	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AEF")]
	[Address(RVA = "0x46C7630", Offset = "0x46C7630", VA = "0x46C7630")]
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AF0")]
	[Address(RVA = "0x46C7718", Offset = "0x46C7718", VA = "0x46C7718")]
	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018AF1")]
	[Address(RVA = "0x46C7828", Offset = "0x46C7828", VA = "0x46C7828")]
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AF2")]
	[Address(RVA = "0x46C7928", Offset = "0x46C7928", VA = "0x46C7928")]
	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AF3")]
	[Address(RVA = "0x46C7A50", Offset = "0x46C7A50", VA = "0x46C7A50")]
	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AF4")]
	[Address(RVA = "0x46C7B58", Offset = "0x46C7B58", VA = "0x46C7B58")]
	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AF5")]
	[Address(RVA = "0x46C7C58", Offset = "0x46C7C58", VA = "0x46C7C58")]
	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AF6")]
	[Address(RVA = "0x46C7D50", Offset = "0x46C7D50", VA = "0x46C7D50")]
	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AF7")]
	[Address(RVA = "0x46C7E78", Offset = "0x46C7E78", VA = "0x46C7E78")]
	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AF8")]
	[Address(RVA = "0x46C7F98", Offset = "0x46C7F98", VA = "0x46C7F98")]
	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AF9")]
	[Address(RVA = "0x46C80B0", Offset = "0x46C80B0", VA = "0x46C80B0")]
	public static extern int CSharp_SeekOnEvent__SWIG_6(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AFA")]
	[Address(RVA = "0x46C81B8", Offset = "0x46C81B8", VA = "0x46C81B8")]
	public static extern int CSharp_SeekOnEvent__SWIG_7(uint jarg1, ulong jarg2, float jarg3, bool jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AFB")]
	[Address(RVA = "0x46C82B8", Offset = "0x46C82B8", VA = "0x46C82B8")]
	public static extern int CSharp_SeekOnEvent__SWIG_8(uint jarg1, ulong jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AFC")]
	[Address(RVA = "0x46C83B0", Offset = "0x46C83B0", VA = "0x46C83B0")]
	public static extern int CSharp_SeekOnEvent__SWIG_9(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018AFD")]
	[Address(RVA = "0x46C84E0", Offset = "0x46C84E0", VA = "0x46C84E0")]
	public static extern int CSharp_SeekOnEvent__SWIG_10(string jarg1, ulong jarg2, float jarg3, bool jarg4);

	[PreserveSig]
	[Token(Token = "0x6018AFE")]
	[Address(RVA = "0x46C8608", Offset = "0x46C8608", VA = "0x46C8608")]
	public static extern int CSharp_SeekOnEvent__SWIG_11(string jarg1, ulong jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018AFF")]
	[Address(RVA = "0x46C8728", Offset = "0x46C8728", VA = "0x46C8728")]
	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B00")]
	[Address(RVA = "0x46C8810", Offset = "0x46C8810", VA = "0x46C8810")]
	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B01")]
	[Address(RVA = "0x46C8900", Offset = "0x46C8900", VA = "0x46C8900")]
	public static extern void CSharp_CancelEventCallback(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B02")]
	[Address(RVA = "0x46C89E0", Offset = "0x46C89E0", VA = "0x46C89E0")]
	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B03")]
	[Address(RVA = "0x46C8AD8", Offset = "0x46C8AD8", VA = "0x46C8AD8")]
	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B04")]
	[Address(RVA = "0x46C8BC8", Offset = "0x46C8BC8", VA = "0x46C8BC8")]
	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B05")]
	[Address(RVA = "0x46C8CB8", Offset = "0x46C8CB8", VA = "0x46C8CB8")]
	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B06")]
	[Address(RVA = "0x46C8DD8", Offset = "0x46C8DD8", VA = "0x46C8DD8")]
	public static extern void CSharp_StopAll__SWIG_1();

	[PreserveSig]
	[Token(Token = "0x6018B07")]
	[Address(RVA = "0x46C8EE0", Offset = "0x46C8EE0", VA = "0x46C8EE0")]
	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B08")]
	[Address(RVA = "0x46C8FD0", Offset = "0x46C8FD0", VA = "0x46C8FD0")]
	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B09")]
	[Address(RVA = "0x46C90B8", Offset = "0x46C90B8", VA = "0x46C90B8")]
	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B0A")]
	[Address(RVA = "0x46C9198", Offset = "0x46C9198", VA = "0x46C9198")]
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B0B")]
	[Address(RVA = "0x46C9298", Offset = "0x46C9298", VA = "0x46C9298")]
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B0C")]
	[Address(RVA = "0x46C9390", Offset = "0x46C9390", VA = "0x46C9390")]
	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B0D")]
	[Address(RVA = "0x46C9480", Offset = "0x46C9480", VA = "0x46C9480")]
	public static extern void CSharp_SetRandomSeed(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B0E")]
	[Address(RVA = "0x46C9590", Offset = "0x46C9590", VA = "0x46C9590")]
	public static extern void CSharp_MuteBackgroundMusic(bool jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B0F")]
	[Address(RVA = "0x46C9670", Offset = "0x46C9670", VA = "0x46C9670")]
	public static extern bool CSharp_GetBackgroundMusicMute();

	[PreserveSig]
	[Token(Token = "0x6018B10")]
	[Address(RVA = "0x46C9750", Offset = "0x46C9750", VA = "0x46C9750")]
	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7);

	[PreserveSig]
	[Token(Token = "0x6018B11")]
	[Address(RVA = "0x46C9868", Offset = "0x46C9868", VA = "0x46C9868")]
	public static extern int CSharp_UnregisterAllGameObj();

	[PreserveSig]
	[Token(Token = "0x6018B12")]
	[Address(RVA = "0x46C9940", Offset = "0x46C9940", VA = "0x46C9940")]
	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B13")]
	[Address(RVA = "0x46C9A48", Offset = "0x46C9A48", VA = "0x46C9A48")]
	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B14")]
	[Address(RVA = "0x46C9B48", Offset = "0x46C9B48", VA = "0x46C9B48")]
	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B15")]
	[Address(RVA = "0x46C9C50", Offset = "0x46C9C50", VA = "0x46C9C50")]
	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B16")]
	[Address(RVA = "0x46C9D50", Offset = "0x46C9D50", VA = "0x46C9D50")]
	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B17")]
	[Address(RVA = "0x46C9E78", Offset = "0x46C9E78", VA = "0x46C9E78")]
	public static extern int CSharp_ClearBanks();

	[PreserveSig]
	[Token(Token = "0x6018B18")]
	[Address(RVA = "0x46C9F70", Offset = "0x46C9F70", VA = "0x46C9F70")]
	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B19")]
	[Address(RVA = "0x46CA058", Offset = "0x46CA058", VA = "0x46CA058")]
	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, int jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B1A")]
	[Address(RVA = "0x46CA1A0", Offset = "0x46CA1A0", VA = "0x46CA1A0")]
	public static extern int CSharp_LoadBank__SWIG_1(uint jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B1B")]
	[Address(RVA = "0x46CA2C0", Offset = "0x46CA2C0", VA = "0x46CA2C0")]
	public static extern int CSharp_LoadBank__SWIG_2(IntPtr jarg1, uint jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B1C")]
	[Address(RVA = "0x46CA3E8", Offset = "0x46CA3E8", VA = "0x46CA3E8")]
	public static extern int CSharp_LoadBank__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3, out uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B1D")]
	[Address(RVA = "0x46CA518", Offset = "0x46CA518", VA = "0x46CA518")]
	public static extern int CSharp_LoadBank__SWIG_4(string jarg1, IntPtr jarg2, IntPtr jarg3, int jarg4, out uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B1E")]
	[Address(RVA = "0x46CA670", Offset = "0x46CA670", VA = "0x46CA670")]
	public static extern int CSharp_LoadBank__SWIG_5(uint jarg1, IntPtr jarg2, IntPtr jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B1F")]
	[Address(RVA = "0x46CA7A0", Offset = "0x46CA7A0", VA = "0x46CA7A0")]
	public static extern int CSharp_LoadBank__SWIG_6(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B20")]
	[Address(RVA = "0x46CA8D8", Offset = "0x46CA8D8", VA = "0x46CA8D8")]
	public static extern int CSharp_LoadBank__SWIG_7(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5, out uint jarg6);

	[PreserveSig]
	[Token(Token = "0x6018B21")]
	[Address(RVA = "0x46CAA18", Offset = "0x46CAA18", VA = "0x46CAA18")]
	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B22")]
	[Address(RVA = "0x46CAB68", Offset = "0x46CAB68", VA = "0x46CAB68")]
	public static extern int CSharp_UnloadBank__SWIG_1(string jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B23")]
	[Address(RVA = "0x46CACB0", Offset = "0x46CACB0", VA = "0x46CACB0")]
	public static extern int CSharp_UnloadBank__SWIG_2(uint jarg1, IntPtr jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B24")]
	[Address(RVA = "0x46CADD8", Offset = "0x46CADD8", VA = "0x46CADD8")]
	public static extern int CSharp_UnloadBank__SWIG_3(uint jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B25")]
	[Address(RVA = "0x46CAEF8", Offset = "0x46CAEF8", VA = "0x46CAEF8")]
	public static extern int CSharp_UnloadBank__SWIG_4(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B26")]
	[Address(RVA = "0x46CB050", Offset = "0x46CB050", VA = "0x46CB050")]
	public static extern int CSharp_UnloadBank__SWIG_5(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B27")]
	[Address(RVA = "0x46CB180", Offset = "0x46CB180", VA = "0x46CB180")]
	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B28")]
	[Address(RVA = "0x46CB260", Offset = "0x46CB260", VA = "0x46CB260")]
	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B29")]
	[Address(RVA = "0x46CB370", Offset = "0x46CB370", VA = "0x46CB370")]
	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B2A")]
	[Address(RVA = "0x46CB478", Offset = "0x46CB478", VA = "0x46CB478")]
	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, uint jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B2B")]
	[Address(RVA = "0x46CB568", Offset = "0x46CB568", VA = "0x46CB568")]
	public static extern int CSharp_PrepareBank__SWIG_3(int jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B2C")]
	[Address(RVA = "0x46CB650", Offset = "0x46CB650", VA = "0x46CB650")]
	public static extern int CSharp_PrepareBank__SWIG_4(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B2D")]
	[Address(RVA = "0x46CB770", Offset = "0x46CB770", VA = "0x46CB770")]
	public static extern int CSharp_PrepareBank__SWIG_5(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B2E")]
	[Address(RVA = "0x46CB888", Offset = "0x46CB888", VA = "0x46CB888")]
	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B2F")]
	[Address(RVA = "0x46CB988", Offset = "0x46CB988", VA = "0x46CB988")]
	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B30")]
	[Address(RVA = "0x46CBA80", Offset = "0x46CBA80", VA = "0x46CBA80")]
	public static extern int CSharp_ClearPreparedEvents();

	[PreserveSig]
	[Token(Token = "0x6018B31")]
	[Address(RVA = "0x46CBB58", Offset = "0x46CBB58", VA = "0x46CBB58")]
	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B32")]
	[Address(RVA = "0x46CBC48", Offset = "0x46CBC48", VA = "0x46CBC48")]
	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, [In] uint[] jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B33")]
	[Address(RVA = "0x46CBD40", Offset = "0x46CBD40", VA = "0x46CBD40")]
	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B34")]
	[Address(RVA = "0x46CBE40", Offset = "0x46CBE40", VA = "0x46CBE40")]
	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, [In] uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B35")]
	[Address(RVA = "0x46CBF48", Offset = "0x46CBF48", VA = "0x46CBF48")]
	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B36")]
	[Address(RVA = "0x46CC058", Offset = "0x46CC058", VA = "0x46CC058")]
	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B37")]
	[Address(RVA = "0x46CC168", Offset = "0x46CC168", VA = "0x46CC168")]
	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B38")]
	[Address(RVA = "0x46CC290", Offset = "0x46CC290", VA = "0x46CC290")]
	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, [In] uint[] jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B39")]
	[Address(RVA = "0x46CC398", Offset = "0x46CC398", VA = "0x46CC398")]
	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7);

	[PreserveSig]
	[Token(Token = "0x6018B3A")]
	[Address(RVA = "0x46CC4D0", Offset = "0x46CC4D0", VA = "0x46CC4D0")]
	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, [In] uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7);

	[PreserveSig]
	[Token(Token = "0x6018B3B")]
	[Address(RVA = "0x46CC5E8", Offset = "0x46CC5E8", VA = "0x46CC5E8")]
	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B3C")]
	[Address(RVA = "0x46CC710", Offset = "0x46CC710", VA = "0x46CC710")]
	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B3D")]
	[Address(RVA = "0x46CC838", Offset = "0x46CC838", VA = "0x46CC838")]
	public static extern int CSharp_AddDefaultListener(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B3E")]
	[Address(RVA = "0x46CC958", Offset = "0x46CC958", VA = "0x46CC958")]
	public static extern int CSharp_RemoveDefaultListener(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B3F")]
	[Address(RVA = "0x46CCA40", Offset = "0x46CCA40", VA = "0x46CCA40")]
	public static extern int CSharp_ResetListenersToDefault(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B40")]
	[Address(RVA = "0x46CCB28", Offset = "0x46CCB28", VA = "0x46CCB28")]
	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, [In] float[] jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B41")]
	[Address(RVA = "0x46CCC40", Offset = "0x46CCC40", VA = "0x46CCC40")]
	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B42")]
	[Address(RVA = "0x46CCD48", Offset = "0x46CCD48", VA = "0x46CCD48")]
	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018B43")]
	[Address(RVA = "0x46CCE58", Offset = "0x46CCE58", VA = "0x46CCE58")]
	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B44")]
	[Address(RVA = "0x46CCF60", Offset = "0x46CCF60", VA = "0x46CCF60")]
	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B45")]
	[Address(RVA = "0x46CD060", Offset = "0x46CD060", VA = "0x46CD060")]
	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B46")]
	[Address(RVA = "0x46CD158", Offset = "0x46CD158", VA = "0x46CD158")]
	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B47")]
	[Address(RVA = "0x46CD240", Offset = "0x46CD240", VA = "0x46CD240")]
	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018B48")]
	[Address(RVA = "0x46CD370", Offset = "0x46CD370", VA = "0x46CD370")]
	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B49")]
	[Address(RVA = "0x46CD498", Offset = "0x46CD498", VA = "0x46CD498")]
	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B4A")]
	[Address(RVA = "0x46CD5B8", Offset = "0x46CD5B8", VA = "0x46CD5B8")]
	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B4B")]
	[Address(RVA = "0x46CD6D0", Offset = "0x46CD6D0", VA = "0x46CD6D0")]
	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B4C")]
	[Address(RVA = "0x46CD7D8", Offset = "0x46CD7D8", VA = "0x46CD7D8")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018B4D")]
	[Address(RVA = "0x46CD8E8", Offset = "0x46CD8E8", VA = "0x46CD8E8")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B4E")]
	[Address(RVA = "0x46CD9F0", Offset = "0x46CD9F0", VA = "0x46CD9F0")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B4F")]
	[Address(RVA = "0x46CDAF0", Offset = "0x46CDAF0", VA = "0x46CDAF0")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B50")]
	[Address(RVA = "0x46CDBE8", Offset = "0x46CDBE8", VA = "0x46CDBE8")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018B51")]
	[Address(RVA = "0x46CDD20", Offset = "0x46CDD20", VA = "0x46CDD20")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B52")]
	[Address(RVA = "0x46CDE50", Offset = "0x46CDE50", VA = "0x46CDE50")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B53")]
	[Address(RVA = "0x46CDF78", Offset = "0x46CDF78", VA = "0x46CDF78")]
	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B54")]
	[Address(RVA = "0x46CE098", Offset = "0x46CE098", VA = "0x46CE098")]
	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B55")]
	[Address(RVA = "0x46CE1A0", Offset = "0x46CE1A0", VA = "0x46CE1A0")]
	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B56")]
	[Address(RVA = "0x46CE2A0", Offset = "0x46CE2A0", VA = "0x46CE2A0")]
	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B57")]
	[Address(RVA = "0x46CE398", Offset = "0x46CE398", VA = "0x46CE398")]
	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B58")]
	[Address(RVA = "0x46CE488", Offset = "0x46CE488", VA = "0x46CE488")]
	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B59")]
	[Address(RVA = "0x46CE568", Offset = "0x46CE568", VA = "0x46CE568")]
	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);

	[PreserveSig]
	[Token(Token = "0x6018B5A")]
	[Address(RVA = "0x46CE698", Offset = "0x46CE698", VA = "0x46CE698")]
	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B5B")]
	[Address(RVA = "0x46CE7C0", Offset = "0x46CE7C0", VA = "0x46CE7C0")]
	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B5C")]
	[Address(RVA = "0x46CE8E0", Offset = "0x46CE8E0", VA = "0x46CE8E0")]
	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B5D")]
	[Address(RVA = "0x46CE9F8", Offset = "0x46CE9F8", VA = "0x46CE9F8")]
	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B5E")]
	[Address(RVA = "0x46CEB00", Offset = "0x46CEB00", VA = "0x46CEB00")]
	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B5F")]
	[Address(RVA = "0x46CEC30", Offset = "0x46CEC30", VA = "0x46CEC30")]
	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B60")]
	[Address(RVA = "0x46CED98", Offset = "0x46CED98", VA = "0x46CED98")]
	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B61")]
	[Address(RVA = "0x46CEE88", Offset = "0x46CEE88", VA = "0x46CEE88")]
	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B62")]
	[Address(RVA = "0x46CEF98", Offset = "0x46CEF98", VA = "0x46CEF98")]
	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B63")]
	[Address(RVA = "0x46CF0B8", Offset = "0x46CF0B8", VA = "0x46CF0B8")]
	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B64")]
	[Address(RVA = "0x46CF208", Offset = "0x46CF208", VA = "0x46CF208")]
	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B65")]
	[Address(RVA = "0x46CF308", Offset = "0x46CF308", VA = "0x46CF308")]
	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B66")]
	[Address(RVA = "0x46CF410", Offset = "0x46CF410", VA = "0x46CF410")]
	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B67")]
	[Address(RVA = "0x46CF500", Offset = "0x46CF500", VA = "0x46CF500")]
	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B68")]
	[Address(RVA = "0x46CF5F0", Offset = "0x46CF5F0", VA = "0x46CF5F0")]
	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B69")]
	[Address(RVA = "0x46CF700", Offset = "0x46CF700", VA = "0x46CF700")]
	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B6A")]
	[Address(RVA = "0x46CF820", Offset = "0x46CF820", VA = "0x46CF820")]
	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B6B")]
	[Address(RVA = "0x46CF960", Offset = "0x46CF960", VA = "0x46CF960")]
	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B6C")]
	[Address(RVA = "0x46CFA48", Offset = "0x46CFA48", VA = "0x46CFA48")]
	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B6D")]
	[Address(RVA = "0x46CFB50", Offset = "0x46CFB50", VA = "0x46CFB50")]
	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B6E")]
	[Address(RVA = "0x46CFC60", Offset = "0x46CFC60", VA = "0x46CFC60")]
	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018B6F")]
	[Address(RVA = "0x46CFD78", Offset = "0x46CFD78", VA = "0x46CFD78")]
	public static extern int CSharp_StartOutputCapture(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B70")]
	[Address(RVA = "0x46CFEB8", Offset = "0x46CFEB8", VA = "0x46CFEB8")]
	public static extern int CSharp_StopOutputCapture();

	[PreserveSig]
	[Token(Token = "0x6018B71")]
	[Address(RVA = "0x46CFFC0", Offset = "0x46CFFC0", VA = "0x46CFFC0")]
	public static extern int CSharp_AddOutputCaptureMarker(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B72")]
	[Address(RVA = "0x46D00C8", Offset = "0x46D00C8", VA = "0x46D00C8")]
	public static extern int CSharp_StartProfilerCapture(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B73")]
	[Address(RVA = "0x46D01C8", Offset = "0x46D01C8", VA = "0x46D01C8")]
	public static extern int CSharp_StopProfilerCapture();

	[PreserveSig]
	[Token(Token = "0x6018B74")]
	[Address(RVA = "0x46D02A0", Offset = "0x46D02A0", VA = "0x46D02A0")]
	public static extern int CSharp_RemoveOutput(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B75")]
	[Address(RVA = "0x46D03B8", Offset = "0x46D03B8", VA = "0x46D03B8")]
	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018B76")]
	[Address(RVA = "0x46D04B0", Offset = "0x46D04B0", VA = "0x46D04B0")]
	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B77")]
	[Address(RVA = "0x46D05A0", Offset = "0x46D05A0", VA = "0x46D05A0")]
	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B78")]
	[Address(RVA = "0x46D0688", Offset = "0x46D0688", VA = "0x46D0688")]
	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B79")]
	[Address(RVA = "0x46D0798", Offset = "0x46D0798", VA = "0x46D0798")]
	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B7A")]
	[Address(RVA = "0x46D0880", Offset = "0x46D0880", VA = "0x46D0880")]
	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B7B")]
	[Address(RVA = "0x46D09A0", Offset = "0x46D09A0", VA = "0x46D09A0")]
	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B7C")]
	[Address(RVA = "0x46D0AC8", Offset = "0x46D0AC8", VA = "0x46D0AC8")]
	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B7D")]
	[Address(RVA = "0x46D0BB0", Offset = "0x46D0BB0", VA = "0x46D0BB0")]
	public static extern int CSharp_Suspend__SWIG_0(bool jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B7E")]
	[Address(RVA = "0x46D0CC8", Offset = "0x46D0CC8", VA = "0x46D0CC8")]
	public static extern int CSharp_Suspend__SWIG_1();

	[PreserveSig]
	[Token(Token = "0x6018B7F")]
	[Address(RVA = "0x46D0DD0", Offset = "0x46D0DD0", VA = "0x46D0DD0")]
	public static extern int CSharp_WakeupFromSuspend();

	[PreserveSig]
	[Token(Token = "0x6018B80")]
	[Address(RVA = "0x46D0ED8", Offset = "0x46D0ED8", VA = "0x46D0ED8")]
	public static extern uint CSharp_GetBufferTick();

	[PreserveSig]
	[Token(Token = "0x6018B81")]
	[Address(RVA = "0x46D0FD8", Offset = "0x46D0FD8", VA = "0x46D0FD8")]
	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B82")]
	[Address(RVA = "0x46D10D0", Offset = "0x46D10D0", VA = "0x46D10D0")]
	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B83")]
	[Address(RVA = "0x46D11C0", Offset = "0x46D11C0", VA = "0x46D11C0")]
	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B84")]
	[Address(RVA = "0x46D12B8", Offset = "0x46D12B8", VA = "0x46D12B8")]
	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B85")]
	[Address(RVA = "0x46D13A8", Offset = "0x46D13A8", VA = "0x46D13A8")]
	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B86")]
	[Address(RVA = "0x46D14A0", Offset = "0x46D14A0", VA = "0x46D14A0")]
	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B87")]
	[Address(RVA = "0x46D1590", Offset = "0x46D1590", VA = "0x46D1590")]
	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B88")]
	[Address(RVA = "0x46D1688", Offset = "0x46D1688", VA = "0x46D1688")]
	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B89")]
	[Address(RVA = "0x46D1778", Offset = "0x46D1778", VA = "0x46D1778")]
	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B8A")]
	[Address(RVA = "0x46D1878", Offset = "0x46D1878", VA = "0x46D1878")]
	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B8B")]
	[Address(RVA = "0x46D1970", Offset = "0x46D1970", VA = "0x46D1970")]
	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B8C")]
	[Address(RVA = "0x46D1A60", Offset = "0x46D1A60", VA = "0x46D1A60")]
	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B8D")]
	[Address(RVA = "0x46D1B48", Offset = "0x46D1B48", VA = "0x46D1B48")]
	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B8E")]
	[Address(RVA = "0x46D1C38", Offset = "0x46D1C38", VA = "0x46D1C38")]
	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B8F")]
	[Address(RVA = "0x46D1D20", Offset = "0x46D1D20", VA = "0x46D1D20")]
	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B90")]
	[Address(RVA = "0x46D1E10", Offset = "0x46D1E10", VA = "0x46D1E10")]
	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B91")]
	[Address(RVA = "0x46D1EF8", Offset = "0x46D1EF8", VA = "0x46D1EF8")]
	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B92")]
	[Address(RVA = "0x46D1FE8", Offset = "0x46D1FE8", VA = "0x46D1FE8")]
	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B93")]
	[Address(RVA = "0x46D20D0", Offset = "0x46D20D0", VA = "0x46D20D0")]
	public static extern IntPtr CSharp_new_AkSegmentInfo();

	[PreserveSig]
	[Token(Token = "0x6018B94")]
	[Address(RVA = "0x46D21D8", Offset = "0x46D21D8", VA = "0x46D21D8")]
	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B95")]
	[Address(RVA = "0x46D22B8", Offset = "0x46D22B8", VA = "0x46D22B8")]
	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get();

	[PreserveSig]
	[Token(Token = "0x6018B96")]
	[Address(RVA = "0x46D2398", Offset = "0x46D2398", VA = "0x46D2398")]
	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get();

	[PreserveSig]
	[Token(Token = "0x6018B97")]
	[Address(RVA = "0x46D2470", Offset = "0x46D2470", VA = "0x46D2470")]
	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B98")]
	[Address(RVA = "0x46D2558", Offset = "0x46D2558", VA = "0x46D2558")]
	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B99")]
	[Address(RVA = "0x46D2638", Offset = "0x46D2638", VA = "0x46D2638")]
	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B9A")]
	[Address(RVA = "0x46D2728", Offset = "0x46D2728", VA = "0x46D2728")]
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B9B")]
	[Address(RVA = "0x46D2810", Offset = "0x46D2810", VA = "0x46D2810")]
	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018B9C")]
	[Address(RVA = "0x46D2900", Offset = "0x46D2900", VA = "0x46D2900")]
	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B9D")]
	[Address(RVA = "0x46D29E8", Offset = "0x46D29E8", VA = "0x46D29E8")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen();

	[PreserveSig]
	[Token(Token = "0x6018B9E")]
	[Address(RVA = "0x46D2AC0", Offset = "0x46D2AC0", VA = "0x46D2AC0")]
	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018B9F")]
	[Address(RVA = "0x46D2BA0", Offset = "0x46D2BA0", VA = "0x46D2BA0")]
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BA0")]
	[Address(RVA = "0x46D2C98", Offset = "0x46D2C98", VA = "0x46D2C98")]
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BA1")]
	[Address(RVA = "0x46D2D88", Offset = "0x46D2D88", VA = "0x46D2D88")]
	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BA2")]
	[Address(RVA = "0x46D2E80", Offset = "0x46D2E80", VA = "0x46D2E80")]
	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BA3")]
	[Address(RVA = "0x46D2F70", Offset = "0x46D2F70", VA = "0x46D2F70")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff();

	[PreserveSig]
	[Token(Token = "0x6018BA4")]
	[Address(RVA = "0x46D3050", Offset = "0x46D3050", VA = "0x46D3050")]
	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BA5")]
	[Address(RVA = "0x46D3138", Offset = "0x46D3138", VA = "0x46D3138")]
	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BA6")]
	[Address(RVA = "0x46D3220", Offset = "0x46D3220", VA = "0x46D3220")]
	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BA7")]
	[Address(RVA = "0x46D3300", Offset = "0x46D3300", VA = "0x46D3300")]
	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BA8")]
	[Address(RVA = "0x46D33F0", Offset = "0x46D33F0", VA = "0x46D33F0")]
	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BA9")]
	[Address(RVA = "0x46D34D8", Offset = "0x46D34D8", VA = "0x46D34D8")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc();

	[PreserveSig]
	[Token(Token = "0x6018BAA")]
	[Address(RVA = "0x46D35B0", Offset = "0x46D35B0", VA = "0x46D35B0")]
	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BAB")]
	[Address(RVA = "0x46D3690", Offset = "0x46D3690", VA = "0x46D3690")]
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BAC")]
	[Address(RVA = "0x46D3788", Offset = "0x46D3788", VA = "0x46D3788")]
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BAD")]
	[Address(RVA = "0x46D3878", Offset = "0x46D3878", VA = "0x46D3878")]
	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BAE")]
	[Address(RVA = "0x46D3970", Offset = "0x46D3970", VA = "0x46D3970")]
	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BAF")]
	[Address(RVA = "0x46D3A60", Offset = "0x46D3A60", VA = "0x46D3A60")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend();

	[PreserveSig]
	[Token(Token = "0x6018BB0")]
	[Address(RVA = "0x46D3B40", Offset = "0x46D3B40", VA = "0x46D3B40")]
	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BB1")]
	[Address(RVA = "0x46D3C28", Offset = "0x46D3C28", VA = "0x46D3C28")]
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BB2")]
	[Address(RVA = "0x46D3D20", Offset = "0x46D3D20", VA = "0x46D3D20")]
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BB3")]
	[Address(RVA = "0x46D3E10", Offset = "0x46D3E10", VA = "0x46D3E10")]
	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BB4")]
	[Address(RVA = "0x46D3F08", Offset = "0x46D3F08", VA = "0x46D3F08")]
	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BB5")]
	[Address(RVA = "0x46D3FF8", Offset = "0x46D3FF8", VA = "0x46D3FF8")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch();

	[PreserveSig]
	[Token(Token = "0x6018BB6")]
	[Address(RVA = "0x46D40D8", Offset = "0x46D40D8", VA = "0x46D40D8")]
	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BB7")]
	[Address(RVA = "0x46D41C8", Offset = "0x46D41C8", VA = "0x46D41C8")]
	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BB8")]
	[Address(RVA = "0x46D42C0", Offset = "0x46D42C0", VA = "0x46D42C0")]
	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BB9")]
	[Address(RVA = "0x46D43B0", Offset = "0x46D43B0", VA = "0x46D43B0")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch();

	[PreserveSig]
	[Token(Token = "0x6018BBA")]
	[Address(RVA = "0x46D4490", Offset = "0x46D4490", VA = "0x46D4490")]
	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BBB")]
	[Address(RVA = "0x46D4580", Offset = "0x46D4580", VA = "0x46D4580")]
	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BBC")]
	[Address(RVA = "0x46D4680", Offset = "0x46D4680", VA = "0x46D4680")]
	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BBD")]
	[Address(RVA = "0x46D4778", Offset = "0x46D4778", VA = "0x46D4778")]
	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange();

	[PreserveSig]
	[Token(Token = "0x6018BBE")]
	[Address(RVA = "0x46D4858", Offset = "0x46D4858", VA = "0x46D4858")]
	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BBF")]
	[Address(RVA = "0x46D4948", Offset = "0x46D4948", VA = "0x46D4948")]
	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BC0")]
	[Address(RVA = "0x46D4A30", Offset = "0x46D4A30", VA = "0x46D4A30")]
	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BC1")]
	[Address(RVA = "0x46D4B10", Offset = "0x46D4B10", VA = "0x46D4B10")]
	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BC2")]
	[Address(RVA = "0x46D4C30", Offset = "0x46D4C30", VA = "0x46D4C30")]
	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BC3")]
	[Address(RVA = "0x46D4D48", Offset = "0x46D4D48", VA = "0x46D4D48")]
	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BC4")]
	[Address(RVA = "0x46D4E38", Offset = "0x46D4E38", VA = "0x46D4E38")]
	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BC5")]
	[Address(RVA = "0x46D4F20", Offset = "0x46D4F20", VA = "0x46D4F20")]
	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BC6")]
	[Address(RVA = "0x46D5010", Offset = "0x46D5010", VA = "0x46D5010")]
	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BC7")]
	[Address(RVA = "0x46D50F8", Offset = "0x46D50F8", VA = "0x46D50F8")]
	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BC8")]
	[Address(RVA = "0x46D51E8", Offset = "0x46D51E8", VA = "0x46D51E8")]
	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BC9")]
	[Address(RVA = "0x46D52D0", Offset = "0x46D52D0", VA = "0x46D52D0")]
	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BCA")]
	[Address(RVA = "0x46D53C0", Offset = "0x46D53C0", VA = "0x46D53C0")]
	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BCB")]
	[Address(RVA = "0x46D54A8", Offset = "0x46D54A8", VA = "0x46D54A8")]
	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BCC")]
	[Address(RVA = "0x46D5598", Offset = "0x46D5598", VA = "0x46D5598")]
	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BCD")]
	[Address(RVA = "0x46D5680", Offset = "0x46D5680", VA = "0x46D5680")]
	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BCE")]
	[Address(RVA = "0x46D5768", Offset = "0x46D5768", VA = "0x46D5768")]
	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BCF")]
	[Address(RVA = "0x46D5848", Offset = "0x46D5848", VA = "0x46D5848")]
	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BD0")]
	[Address(RVA = "0x46D5938", Offset = "0x46D5938", VA = "0x46D5938")]
	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BD1")]
	[Address(RVA = "0x46D5A20", Offset = "0x46D5A20", VA = "0x46D5A20")]
	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BD2")]
	[Address(RVA = "0x46D5B10", Offset = "0x46D5B10", VA = "0x46D5B10")]
	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BD3")]
	[Address(RVA = "0x46D5BF8", Offset = "0x46D5BF8", VA = "0x46D5BF8")]
	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BD4")]
	[Address(RVA = "0x46D5CE0", Offset = "0x46D5CE0", VA = "0x46D5CE0")]
	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BD5")]
	[Address(RVA = "0x46D5DC0", Offset = "0x46D5DC0", VA = "0x46D5DC0")]
	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BD6")]
	[Address(RVA = "0x46D5EB0", Offset = "0x46D5EB0", VA = "0x46D5EB0")]
	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BD7")]
	[Address(RVA = "0x46D5F98", Offset = "0x46D5F98", VA = "0x46D5F98")]
	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BD8")]
	[Address(RVA = "0x46D6088", Offset = "0x46D6088", VA = "0x46D6088")]
	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BD9")]
	[Address(RVA = "0x46D6170", Offset = "0x46D6170", VA = "0x46D6170")]
	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BDA")]
	[Address(RVA = "0x46D6260", Offset = "0x46D6260", VA = "0x46D6260")]
	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BDB")]
	[Address(RVA = "0x46D6348", Offset = "0x46D6348", VA = "0x46D6348")]
	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BDC")]
	[Address(RVA = "0x46D6438", Offset = "0x46D6438", VA = "0x46D6438")]
	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BDD")]
	[Address(RVA = "0x46D6520", Offset = "0x46D6520", VA = "0x46D6520")]
	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BDE")]
	[Address(RVA = "0x46D6618", Offset = "0x46D6618", VA = "0x46D6618")]
	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BDF")]
	[Address(RVA = "0x46D6708", Offset = "0x46D6708", VA = "0x46D6708")]
	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BE0")]
	[Address(RVA = "0x46D6800", Offset = "0x46D6800", VA = "0x46D6800")]
	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BE1")]
	[Address(RVA = "0x46D68F0", Offset = "0x46D68F0", VA = "0x46D68F0")]
	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BE2")]
	[Address(RVA = "0x46D69E0", Offset = "0x46D69E0", VA = "0x46D69E0")]
	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BE3")]
	[Address(RVA = "0x46D6AC8", Offset = "0x46D6AC8", VA = "0x46D6AC8")]
	public static extern IntPtr CSharp_new_AkMIDIEvent();

	[PreserveSig]
	[Token(Token = "0x6018BE4")]
	[Address(RVA = "0x46D6BD0", Offset = "0x46D6BD0", VA = "0x46D6BD0")]
	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BE5")]
	[Address(RVA = "0x46D6CE8", Offset = "0x46D6CE8", VA = "0x46D6CE8")]
	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BE6")]
	[Address(RVA = "0x46D6DD0", Offset = "0x46D6DD0", VA = "0x46D6DD0")]
	public static extern uint CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BE7")]
	[Address(RVA = "0x46D6EB0", Offset = "0x46D6EB0", VA = "0x46D6EB0")]
	public static extern int CSharp_AkMIDIPost_PostOnEvent(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018BE8")]
	[Address(RVA = "0x46D6FB0", Offset = "0x46D6FB0", VA = "0x46D6FB0")]
	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BE9")]
	[Address(RVA = "0x46D70D0", Offset = "0x46D70D0", VA = "0x46D70D0")]
	public static extern int CSharp_AkMIDIPost_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018BEA")]
	[Address(RVA = "0x46D71A8", Offset = "0x46D71A8", VA = "0x46D71A8")]
	public static extern IntPtr CSharp_new_AkMIDIPost();

	[PreserveSig]
	[Token(Token = "0x6018BEB")]
	[Address(RVA = "0x46D72A8", Offset = "0x46D72A8", VA = "0x46D72A8")]
	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BEC")]
	[Address(RVA = "0x46D73C0", Offset = "0x46D73C0", VA = "0x46D73C0")]
	public static extern IntPtr CSharp_new_AkMemSettings();

	[PreserveSig]
	[Token(Token = "0x6018BED")]
	[Address(RVA = "0x46D74C8", Offset = "0x46D74C8", VA = "0x46D74C8")]
	public static extern void CSharp_AkMemSettings_uMaxNumPools_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BEE")]
	[Address(RVA = "0x46D75B8", Offset = "0x46D75B8", VA = "0x46D75B8")]
	public static extern uint CSharp_AkMemSettings_uMaxNumPools_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BEF")]
	[Address(RVA = "0x46D76A0", Offset = "0x46D76A0", VA = "0x46D76A0")]
	public static extern void CSharp_AkMemSettings_uDebugFlags_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BF0")]
	[Address(RVA = "0x46D7790", Offset = "0x46D7790", VA = "0x46D7790")]
	public static extern uint CSharp_AkMemSettings_uDebugFlags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BF1")]
	[Address(RVA = "0x46D7878", Offset = "0x46D7878", VA = "0x46D7878")]
	public static extern void CSharp_delete_AkMemSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BF2")]
	[Address(RVA = "0x46D7958", Offset = "0x46D7958", VA = "0x46D7958")]
	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BF3")]
	[Address(RVA = "0x46D7A58", Offset = "0x46D7A58", VA = "0x46D7A58")]
	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BF4")]
	[Address(RVA = "0x46D7B50", Offset = "0x46D7B50", VA = "0x46D7B50")]
	public static extern IntPtr CSharp_new_AkMusicSettings();

	[PreserveSig]
	[Token(Token = "0x6018BF5")]
	[Address(RVA = "0x46D7C28", Offset = "0x46D7C28", VA = "0x46D7C28")]
	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BF6")]
	[Address(RVA = "0x46D7D08", Offset = "0x46D7D08", VA = "0x46D7D08")]
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3);

	[PreserveSig]
	[Token(Token = "0x6018BF7")]
	[Address(RVA = "0x46D7E00", Offset = "0x46D7E00", VA = "0x46D7E00")]
	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018BF8")]
	[Address(RVA = "0x46D7EF0", Offset = "0x46D7EF0", VA = "0x46D7EF0")]
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BF9")]
	[Address(RVA = "0x46D7FE0", Offset = "0x46D7FE0", VA = "0x46D7FE0")]
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BFA")]
	[Address(RVA = "0x46D80D0", Offset = "0x46D80D0", VA = "0x46D80D0")]
	public static extern int CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BFB")]
	[Address(RVA = "0x46D81C0", Offset = "0x46D81C0", VA = "0x46D81C0")]
	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BFC")]
	[Address(RVA = "0x46D82B0", Offset = "0x46D82B0", VA = "0x46D82B0")]
	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader();

	[PreserveSig]
	[Token(Token = "0x6018BFD")]
	[Address(RVA = "0x46D8390", Offset = "0x46D8390", VA = "0x46D8390")]
	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BFE")]
	[Address(RVA = "0x46D8480", Offset = "0x46D8480", VA = "0x46D8480")]
	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018BFF")]
	[Address(RVA = "0x46D8568", Offset = "0x46D8568", VA = "0x46D8568")]
	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C00")]
	[Address(RVA = "0x46D8650", Offset = "0x46D8650", VA = "0x46D8650")]
	public static extern IntPtr CSharp_new_AkCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C01")]
	[Address(RVA = "0x46D8758", Offset = "0x46D8758", VA = "0x46D8758")]
	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C02")]
	[Address(RVA = "0x46D8838", Offset = "0x46D8838", VA = "0x46D8838")]
	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C03")]
	[Address(RVA = "0x46D8928", Offset = "0x46D8928", VA = "0x46D8928")]
	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C04")]
	[Address(RVA = "0x46D8A10", Offset = "0x46D8A10", VA = "0x46D8A10")]
	public static extern IntPtr CSharp_new_AkEventCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C05")]
	[Address(RVA = "0x46D8AE8", Offset = "0x46D8AE8", VA = "0x46D8AE8")]
	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C06")]
	[Address(RVA = "0x46D8BD0", Offset = "0x46D8BD0", VA = "0x46D8BD0")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C07")]
	[Address(RVA = "0x46D8CC0", Offset = "0x46D8CC0", VA = "0x46D8CC0")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C08")]
	[Address(RVA = "0x46D8DB0", Offset = "0x46D8DB0", VA = "0x46D8DB0")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C09")]
	[Address(RVA = "0x46D8EA0", Offset = "0x46D8EA0", VA = "0x46D8EA0")]
	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0A")]
	[Address(RVA = "0x46D8F90", Offset = "0x46D8F90", VA = "0x46D8F90")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0B")]
	[Address(RVA = "0x46D9080", Offset = "0x46D9080", VA = "0x46D9080")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0C")]
	[Address(RVA = "0x46D9170", Offset = "0x46D9170", VA = "0x46D9170")]
	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0D")]
	[Address(RVA = "0x46D9258", Offset = "0x46D9258", VA = "0x46D9258")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0E")]
	[Address(RVA = "0x46D9348", Offset = "0x46D9348", VA = "0x46D9348")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C0F")]
	[Address(RVA = "0x46D9438", Offset = "0x46D9438", VA = "0x46D9438")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C10")]
	[Address(RVA = "0x46D9528", Offset = "0x46D9528", VA = "0x46D9528")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C11")]
	[Address(RVA = "0x46D9620", Offset = "0x46D9620", VA = "0x46D9620")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C12")]
	[Address(RVA = "0x46D9720", Offset = "0x46D9720", VA = "0x46D9720")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C13")]
	[Address(RVA = "0x46D9820", Offset = "0x46D9820", VA = "0x46D9820")]
	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C14")]
	[Address(RVA = "0x46D9910", Offset = "0x46D9910", VA = "0x46D9910")]
	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C15")]
	[Address(RVA = "0x46D99F0", Offset = "0x46D99F0", VA = "0x46D99F0")]
	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C16")]
	[Address(RVA = "0x46D9AD8", Offset = "0x46D9AD8", VA = "0x46D9AD8")]
	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C17")]
	[Address(RVA = "0x46D9BC8", Offset = "0x46D9BC8", VA = "0x46D9BC8")]
	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C18")]
	[Address(RVA = "0x46D9CB8", Offset = "0x46D9CB8", VA = "0x46D9CB8")]
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C19")]
	[Address(RVA = "0x46D9DA8", Offset = "0x46D9DA8", VA = "0x46D9DA8")]
	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C1A")]
	[Address(RVA = "0x46D9E80", Offset = "0x46D9E80", VA = "0x46D9E80")]
	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C1B")]
	[Address(RVA = "0x46D9F68", Offset = "0x46D9F68", VA = "0x46D9F68")]
	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C1C")]
	[Address(RVA = "0x46DA058", Offset = "0x46DA058", VA = "0x46DA058")]
	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C1D")]
	[Address(RVA = "0x46DA150", Offset = "0x46DA150", VA = "0x46DA150")]
	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C1E")]
	[Address(RVA = "0x46DA240", Offset = "0x46DA240", VA = "0x46DA240")]
	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C1F")]
	[Address(RVA = "0x46DA330", Offset = "0x46DA330", VA = "0x46DA330")]
	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C20")]
	[Address(RVA = "0x46DA428", Offset = "0x46DA428", VA = "0x46DA428")]
	public static extern IntPtr CSharp_new_AkDurationCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C21")]
	[Address(RVA = "0x46DA508", Offset = "0x46DA508", VA = "0x46DA508")]
	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C22")]
	[Address(RVA = "0x46DA5F0", Offset = "0x46DA5F0", VA = "0x46DA5F0")]
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C23")]
	[Address(RVA = "0x46DA6E8", Offset = "0x46DA6E8", VA = "0x46DA6E8")]
	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C24")]
	[Address(RVA = "0x46DA7E8", Offset = "0x46DA7E8", VA = "0x46DA7E8")]
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C25")]
	[Address(RVA = "0x46DA8E8", Offset = "0x46DA8E8", VA = "0x46DA8E8")]
	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C26")]
	[Address(RVA = "0x46DA9D0", Offset = "0x46DA9D0", VA = "0x46DA9D0")]
	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C27")]
	[Address(RVA = "0x46DAAC0", Offset = "0x46DAAC0", VA = "0x46DAAC0")]
	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C28")]
	[Address(RVA = "0x46DABB0", Offset = "0x46DABB0", VA = "0x46DABB0")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C29")]
	[Address(RVA = "0x46DACB0", Offset = "0x46DACB0", VA = "0x46DACB0")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2A")]
	[Address(RVA = "0x46DAD80", Offset = "0x46DAD80", VA = "0x46DAD80")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2B")]
	[Address(RVA = "0x46DAE80", Offset = "0x46DAE80", VA = "0x46DAE80")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2C")]
	[Address(RVA = "0x46DAF50", Offset = "0x46DAF50", VA = "0x46DAF50")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2D")]
	[Address(RVA = "0x46DB020", Offset = "0x46DB020", VA = "0x46DB020")]
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2E")]
	[Address(RVA = "0x46DB120", Offset = "0x46DB120", VA = "0x46DB120")]
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C2F")]
	[Address(RVA = "0x46DB220", Offset = "0x46DB220", VA = "0x46DB220")]
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C30")]
	[Address(RVA = "0x46DB320", Offset = "0x46DB320", VA = "0x46DB320")]
	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C31")]
	[Address(RVA = "0x46DB420", Offset = "0x46DB420", VA = "0x46DB420")]
	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C32")]
	[Address(RVA = "0x46DB518", Offset = "0x46DB518", VA = "0x46DB518")]
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C33")]
	[Address(RVA = "0x46DB608", Offset = "0x46DB608", VA = "0x46DB608")]
	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C34")]
	[Address(RVA = "0x46DB6E8", Offset = "0x46DB6E8", VA = "0x46DB6E8")]
	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C35")]
	[Address(RVA = "0x46DB7D0", Offset = "0x46DB7D0", VA = "0x46DB7D0")]
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C36")]
	[Address(RVA = "0x46DB8C8", Offset = "0x46DB8C8", VA = "0x46DB8C8")]
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C37")]
	[Address(RVA = "0x46DB9C8", Offset = "0x46DB9C8", VA = "0x46DB9C8")]
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C38")]
	[Address(RVA = "0x46DBAC8", Offset = "0x46DBAC8", VA = "0x46DBAC8")]
	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C39")]
	[Address(RVA = "0x46DBBC8", Offset = "0x46DBBC8", VA = "0x46DBBC8")]
	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C3A")]
	[Address(RVA = "0x46DBCA8", Offset = "0x46DBCA8", VA = "0x46DBCA8")]
	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C3B")]
	[Address(RVA = "0x46DBD98", Offset = "0x46DBD98", VA = "0x46DBD98")]
	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C3C")]
	[Address(RVA = "0x46DBE80", Offset = "0x46DBE80", VA = "0x46DBE80")]
	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C3D")]
	[Address(RVA = "0x46DBF70", Offset = "0x46DBF70", VA = "0x46DBF70")]
	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C3E")]
	[Address(RVA = "0x46DC060", Offset = "0x46DC060", VA = "0x46DC060")]
	public static extern int CSharp_AkBankCallbackInfo_memPoolId_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C3F")]
	[Address(RVA = "0x46DC148", Offset = "0x46DC148", VA = "0x46DC148")]
	public static extern IntPtr CSharp_new_AkBankCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C40")]
	[Address(RVA = "0x46DC220", Offset = "0x46DC220", VA = "0x46DC220")]
	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C41")]
	[Address(RVA = "0x46DC308", Offset = "0x46DC308", VA = "0x46DC308")]
	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C42")]
	[Address(RVA = "0x46DC3F8", Offset = "0x46DC3F8", VA = "0x46DC3F8")]
	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C43")]
	[Address(RVA = "0x46DC4E8", Offset = "0x46DC4E8", VA = "0x46DC4E8")]
	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C44")]
	[Address(RVA = "0x46DC5D8", Offset = "0x46DC5D8", VA = "0x46DC5D8")]
	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C45")]
	[Address(RVA = "0x46DC6C8", Offset = "0x46DC6C8", VA = "0x46DC6C8")]
	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C46")]
	[Address(RVA = "0x46DC7B8", Offset = "0x46DC7B8", VA = "0x46DC7B8")]
	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C47")]
	[Address(RVA = "0x46DC898", Offset = "0x46DC898", VA = "0x46DC898")]
	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C48")]
	[Address(RVA = "0x46DC980", Offset = "0x46DC980", VA = "0x46DC980")]
	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C49")]
	[Address(RVA = "0x46DCA88", Offset = "0x46DCA88", VA = "0x46DCA88")]
	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C4A")]
	[Address(RVA = "0x46DCB70", Offset = "0x46DCB70", VA = "0x46DCB70")]
	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C4B")]
	[Address(RVA = "0x46DCC60", Offset = "0x46DCC60", VA = "0x46DCC60")]
	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C4C")]
	[Address(RVA = "0x46DCD68", Offset = "0x46DCD68", VA = "0x46DCD68")]
	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo();

	[PreserveSig]
	[Token(Token = "0x6018C4D")]
	[Address(RVA = "0x46DCE50", Offset = "0x46DCE50", VA = "0x46DCE50")]
	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C4E")]
	[Address(RVA = "0x46DCF40", Offset = "0x46DCF40", VA = "0x46DCF40")]
	public static extern int CSharp_AkCallbackSerializer_Init(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C4F")]
	[Address(RVA = "0x46DD030", Offset = "0x46DD030", VA = "0x46DD030")]
	public static extern void CSharp_AkCallbackSerializer_Term();

	[PreserveSig]
	[Token(Token = "0x6018C50")]
	[Address(RVA = "0x46DD110", Offset = "0x46DD110", VA = "0x46DD110")]
	public static extern IntPtr CSharp_AkCallbackSerializer_Lock();

	[PreserveSig]
	[Token(Token = "0x6018C51")]
	[Address(RVA = "0x46DD1F0", Offset = "0x46DD1F0", VA = "0x46DD1F0")]
	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C52")]
	[Address(RVA = "0x46DD2E0", Offset = "0x46DD2E0", VA = "0x46DD2E0")]
	public static extern void CSharp_AkCallbackSerializer_Unlock();

	[PreserveSig]
	[Token(Token = "0x6018C53")]
	[Address(RVA = "0x46DD3C0", Offset = "0x46DD3C0", VA = "0x46DD3C0")]
	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C54")]
	[Address(RVA = "0x46DD4C8", Offset = "0x46DD4C8", VA = "0x46DD4C8")]
	public static extern IntPtr CSharp_new_AkCallbackSerializer();

	[PreserveSig]
	[Token(Token = "0x6018C55")]
	[Address(RVA = "0x46DD5A0", Offset = "0x46DD5A0", VA = "0x46DD5A0")]
	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C56")]
	[Address(RVA = "0x46DD688", Offset = "0x46DD688", VA = "0x46DD688")]
	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018C57")]
	[Address(RVA = "0x46DD7C8", Offset = "0x46DD7C8", VA = "0x46DD7C8")]
	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018C58")]
	[Address(RVA = "0x46DD900", Offset = "0x46DD900", VA = "0x46DD900")]
	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4);

	[PreserveSig]
	[Token(Token = "0x6018C59")]
	[Address(RVA = "0x46DDA38", Offset = "0x46DDA38", VA = "0x46DDA38")]
	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C5A")]
	[Address(RVA = "0x46DDB60", Offset = "0x46DDB60", VA = "0x46DDB60")]
	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C5B")]
	[Address(RVA = "0x46DDC80", Offset = "0x46DDC80", VA = "0x46DDC80")]
	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018C5C")]
	[Address(RVA = "0x46DDDE8", Offset = "0x46DDDE8", VA = "0x46DDDE8")]
	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018C5D")]
	[Address(RVA = "0x46DDF48", Offset = "0x46DDF48", VA = "0x46DDF48")]
	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4);

	[PreserveSig]
	[Token(Token = "0x6018C5E")]
	[Address(RVA = "0x46DE0A0", Offset = "0x46DE0A0", VA = "0x46DE0A0")]
	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C5F")]
	[Address(RVA = "0x46DE1F0", Offset = "0x46DE1F0", VA = "0x46DE1F0")]
	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C60")]
	[Address(RVA = "0x46DE338", Offset = "0x46DE338", VA = "0x46DE338")]
	public static extern int CSharp_GetTimeStamp();

	[PreserveSig]
	[Token(Token = "0x6018C61")]
	[Address(RVA = "0x46DE438", Offset = "0x46DE438", VA = "0x46DE438")]
	public static extern uint CSharp_GetNumNonZeroBits(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C62")]
	[Address(RVA = "0x46DE550", Offset = "0x46DE550", VA = "0x46DE550")]
	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C63")]
	[Address(RVA = "0x46DE640", Offset = "0x46DE640", VA = "0x46DE640")]
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, [In] uint[] jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018C64")]
	[Address(RVA = "0x46DE748", Offset = "0x46DE748", VA = "0x46DE748")]
	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, [In] uint[] jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C65")]
	[Address(RVA = "0x46DE848", Offset = "0x46DE848", VA = "0x46DE848")]
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C66")]
	[Address(RVA = "0x46DE950", Offset = "0x46DE950", VA = "0x46DE950")]
	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C67")]
	[Address(RVA = "0x46DEA58", Offset = "0x46DEA58", VA = "0x46DEA58")]
	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C68")]
	[Address(RVA = "0x46DEB48", Offset = "0x46DEB48", VA = "0x46DEB48")]
	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C69")]
	[Address(RVA = "0x46DEC30", Offset = "0x46DEC30", VA = "0x46DEC30")]
	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C6A")]
	[Address(RVA = "0x46DED20", Offset = "0x46DED20", VA = "0x46DED20")]
	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C6B")]
	[Address(RVA = "0x46DEE08", Offset = "0x46DEE08", VA = "0x46DEE08")]
	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C6C")]
	[Address(RVA = "0x46DEF00", Offset = "0x46DEF00", VA = "0x46DEF00")]
	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C6D")]
	[Address(RVA = "0x46DEFF0", Offset = "0x46DEFF0", VA = "0x46DEFF0")]
	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C6E")]
	[Address(RVA = "0x46DF0F0", Offset = "0x46DF0F0", VA = "0x46DF0F0")]
	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C6F")]
	[Address(RVA = "0x46DF1F0", Offset = "0x46DF1F0", VA = "0x46DF1F0")]
	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C70")]
	[Address(RVA = "0x46DF2F0", Offset = "0x46DF2F0", VA = "0x46DF2F0")]
	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C71")]
	[Address(RVA = "0x46DF3E8", Offset = "0x46DF3E8", VA = "0x46DF3E8")]
	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C72")]
	[Address(RVA = "0x46DF4E0", Offset = "0x46DF4E0", VA = "0x46DF4E0")]
	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C73")]
	[Address(RVA = "0x46DF5D8", Offset = "0x46DF5D8", VA = "0x46DF5D8")]
	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C74")]
	[Address(RVA = "0x46DF6D8", Offset = "0x46DF6D8", VA = "0x46DF6D8")]
	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C75")]
	[Address(RVA = "0x46DF7D8", Offset = "0x46DF7D8", VA = "0x46DF7D8")]
	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C76")]
	[Address(RVA = "0x46DF8D0", Offset = "0x46DF8D0", VA = "0x46DF8D0")]
	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C77")]
	[Address(RVA = "0x46DF9C0", Offset = "0x46DF9C0", VA = "0x46DF9C0")]
	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C78")]
	[Address(RVA = "0x46DFAB8", Offset = "0x46DFAB8", VA = "0x46DFAB8")]
	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C79")]
	[Address(RVA = "0x46DFBA8", Offset = "0x46DFBA8", VA = "0x46DFBA8")]
	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C7A")]
	[Address(RVA = "0x46DFCA8", Offset = "0x46DFCA8", VA = "0x46DFCA8")]
	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C7B")]
	[Address(RVA = "0x46DFDA0", Offset = "0x46DFDA0", VA = "0x46DFDA0")]
	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C7C")]
	[Address(RVA = "0x46DFE90", Offset = "0x46DFE90", VA = "0x46DFE90")]
	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C7D")]
	[Address(RVA = "0x46DFF78", Offset = "0x46DFF78", VA = "0x46DFF78")]
	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C7E")]
	[Address(RVA = "0x46E0068", Offset = "0x46E0068", VA = "0x46E0068")]
	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C7F")]
	[Address(RVA = "0x46E0150", Offset = "0x46E0150", VA = "0x46E0150")]
	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C80")]
	[Address(RVA = "0x46E0248", Offset = "0x46E0248", VA = "0x46E0248")]
	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C81")]
	[Address(RVA = "0x46E0338", Offset = "0x46E0338", VA = "0x46E0338")]
	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C82")]
	[Address(RVA = "0x46E0430", Offset = "0x46E0430", VA = "0x46E0430")]
	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C83")]
	[Address(RVA = "0x46E0520", Offset = "0x46E0520", VA = "0x46E0520")]
	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C84")]
	[Address(RVA = "0x46E0620", Offset = "0x46E0620", VA = "0x46E0620")]
	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C85")]
	[Address(RVA = "0x46E0718", Offset = "0x46E0718", VA = "0x46E0718")]
	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C86")]
	[Address(RVA = "0x46E0818", Offset = "0x46E0818", VA = "0x46E0818")]
	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C87")]
	[Address(RVA = "0x46E0910", Offset = "0x46E0910", VA = "0x46E0910")]
	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C88")]
	[Address(RVA = "0x46E0A08", Offset = "0x46E0A08", VA = "0x46E0A08")]
	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C89")]
	[Address(RVA = "0x46E0AF8", Offset = "0x46E0AF8", VA = "0x46E0AF8")]
	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C8A")]
	[Address(RVA = "0x46E0BF0", Offset = "0x46E0BF0", VA = "0x46E0BF0")]
	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C8B")]
	[Address(RVA = "0x46E0CE0", Offset = "0x46E0CE0", VA = "0x46E0CE0")]
	public static extern IntPtr CSharp_new_AkPositioningInfo();

	[PreserveSig]
	[Token(Token = "0x6018C8C")]
	[Address(RVA = "0x46E0DB8", Offset = "0x46E0DB8", VA = "0x46E0DB8")]
	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C8D")]
	[Address(RVA = "0x46E0E98", Offset = "0x46E0E98", VA = "0x46E0E98")]
	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C8E")]
	[Address(RVA = "0x46E0F80", Offset = "0x46E0F80", VA = "0x46E0F80")]
	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C8F")]
	[Address(RVA = "0x46E1060", Offset = "0x46E1060", VA = "0x46E1060")]
	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C90")]
	[Address(RVA = "0x46E1150", Offset = "0x46E1150", VA = "0x46E1150")]
	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C91")]
	[Address(RVA = "0x46E1238", Offset = "0x46E1238", VA = "0x46E1238")]
	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C92")]
	[Address(RVA = "0x46E1320", Offset = "0x46E1320", VA = "0x46E1320")]
	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C93")]
	[Address(RVA = "0x46E1400", Offset = "0x46E1400", VA = "0x46E1400")]
	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C94")]
	[Address(RVA = "0x46E1518", Offset = "0x46E1518", VA = "0x46E1518")]
	public static extern int CSharp_AkObjectInfo_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018C95")]
	[Address(RVA = "0x46E15F0", Offset = "0x46E15F0", VA = "0x46E15F0")]
	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C96")]
	[Address(RVA = "0x46E1710", Offset = "0x46E1710", VA = "0x46E1710")]
	public static extern IntPtr CSharp_new_AkObjectInfo();

	[PreserveSig]
	[Token(Token = "0x6018C97")]
	[Address(RVA = "0x46E1818", Offset = "0x46E1818", VA = "0x46E1818")]
	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018C98")]
	[Address(RVA = "0x46E18F8", Offset = "0x46E18F8", VA = "0x46E18F8")]
	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C99")]
	[Address(RVA = "0x46E1A18", Offset = "0x46E1A18", VA = "0x46E1A18")]
	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C9A")]
	[Address(RVA = "0x46E1B08", Offset = "0x46E1B08", VA = "0x46E1B08")]
	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018C9B")]
	[Address(RVA = "0x46E1C10", Offset = "0x46E1C10", VA = "0x46E1C10")]
	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5);

	[PreserveSig]
	[Token(Token = "0x6018C9C")]
	[Address(RVA = "0x46E1D38", Offset = "0x46E1D38", VA = "0x46E1D38")]
	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C9D")]
	[Address(RVA = "0x46E1E68", Offset = "0x46E1E68", VA = "0x46E1E68")]
	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018C9E")]
	[Address(RVA = "0x46E1FC0", Offset = "0x46E1FC0", VA = "0x46E1FC0")]
	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018C9F")]
	[Address(RVA = "0x46E20E0", Offset = "0x46E20E0", VA = "0x46E20E0")]
	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CA0")]
	[Address(RVA = "0x46E2220", Offset = "0x46E2220", VA = "0x46E2220")]
	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CA1")]
	[Address(RVA = "0x46E2320", Offset = "0x46E2320", VA = "0x46E2320")]
	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CA2")]
	[Address(RVA = "0x46E2428", Offset = "0x46E2428", VA = "0x46E2428")]
	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4);

	[PreserveSig]
	[Token(Token = "0x6018CA3")]
	[Address(RVA = "0x46E2538", Offset = "0x46E2538", VA = "0x46E2538")]
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CA4")]
	[Address(RVA = "0x46E2630", Offset = "0x46E2630", VA = "0x46E2630")]
	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CA5")]
	[Address(RVA = "0x46E2748", Offset = "0x46E2748", VA = "0x46E2748")]
	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CA6")]
	[Address(RVA = "0x46E2868", Offset = "0x46E2868", VA = "0x46E2868")]
	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CA7")]
	[Address(RVA = "0x46E2958", Offset = "0x46E2958", VA = "0x46E2958")]
	public static extern float CSharp_GetMaxRadius(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CA8")]
	[Address(RVA = "0x46E2A70", Offset = "0x46E2A70", VA = "0x46E2A70")]
	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CA9")]
	[Address(RVA = "0x46E2B50", Offset = "0x46E2B50", VA = "0x46E2B50")]
	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CAA")]
	[Address(RVA = "0x46E2C38", Offset = "0x46E2C38", VA = "0x46E2C38")]
	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, [Out] uint[] jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CAB")]
	[Address(RVA = "0x46E2DD0", Offset = "0x46E2DD0", VA = "0x46E2DD0")]
	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CAC")]
	[Address(RVA = "0x46E2EC8", Offset = "0x46E2EC8", VA = "0x46E2EC8")]
	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CAD")]
	[Address(RVA = "0x46E2FC0", Offset = "0x46E2FC0", VA = "0x46E2FC0")]
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CAE")]
	[Address(RVA = "0x46E30B0", Offset = "0x46E30B0", VA = "0x46E30B0")]
	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CAF")]
	[Address(RVA = "0x46E31A0", Offset = "0x46E31A0", VA = "0x46E31A0")]
	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB0")]
	[Address(RVA = "0x46E3290", Offset = "0x46E3290", VA = "0x46E3290")]
	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB1")]
	[Address(RVA = "0x46E3370", Offset = "0x46E3370", VA = "0x46E3370")]
	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB2")]
	[Address(RVA = "0x46E3458", Offset = "0x46E3458", VA = "0x46E3458")]
	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CB3")]
	[Address(RVA = "0x46E3578", Offset = "0x46E3578", VA = "0x46E3578")]
	public static extern bool CSharp_HasSurroundChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB4")]
	[Address(RVA = "0x46E3660", Offset = "0x46E3660", VA = "0x46E3660")]
	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB5")]
	[Address(RVA = "0x46E3758", Offset = "0x46E3758", VA = "0x46E3758")]
	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB6")]
	[Address(RVA = "0x46E3840", Offset = "0x46E3840", VA = "0x46E3840")]
	public static extern bool CSharp_HasHeightChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB7")]
	[Address(RVA = "0x46E3960", Offset = "0x46E3960", VA = "0x46E3960")]
	public static extern uint CSharp_BackToSideChannels(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CB8")]
	[Address(RVA = "0x46E3A78", Offset = "0x46E3A78", VA = "0x46E3A78")]
	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CB9")]
	[Address(RVA = "0x46E3B70", Offset = "0x46E3B70", VA = "0x46E3B70")]
	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CBA")]
	[Address(RVA = "0x46E3C60", Offset = "0x46E3C60", VA = "0x46E3C60")]
	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CBB")]
	[Address(RVA = "0x46E3D48", Offset = "0x46E3D48", VA = "0x46E3D48")]
	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CBC")]
	[Address(RVA = "0x46E3E38", Offset = "0x46E3E38", VA = "0x46E3E38")]
	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CBD")]
	[Address(RVA = "0x46E3F20", Offset = "0x46E3F20", VA = "0x46E3F20")]
	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CBE")]
	[Address(RVA = "0x46E4010", Offset = "0x46E4010", VA = "0x46E4010")]
	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CBF")]
	[Address(RVA = "0x46E40F8", Offset = "0x46E40F8", VA = "0x46E40F8")]
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018CC0")]
	[Address(RVA = "0x46E41D8", Offset = "0x46E41D8", VA = "0x46E41D8")]
	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CC1")]
	[Address(RVA = "0x46E42C8", Offset = "0x46E42C8", VA = "0x46E42C8")]
	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CC2")]
	[Address(RVA = "0x46E43A8", Offset = "0x46E43A8", VA = "0x46E43A8")]
	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CC3")]
	[Address(RVA = "0x46E4498", Offset = "0x46E4498", VA = "0x46E4498")]
	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CC4")]
	[Address(RVA = "0x46E4598", Offset = "0x46E4598", VA = "0x46E4598")]
	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CC5")]
	[Address(RVA = "0x46E4688", Offset = "0x46E4688", VA = "0x46E4688")]
	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CC6")]
	[Address(RVA = "0x46E4778", Offset = "0x46E4778", VA = "0x46E4778")]
	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CC7")]
	[Address(RVA = "0x46E4860", Offset = "0x46E4860", VA = "0x46E4860")]
	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CC8")]
	[Address(RVA = "0x46E4948", Offset = "0x46E4948", VA = "0x46E4948")]
	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CC9")]
	[Address(RVA = "0x46E4A38", Offset = "0x46E4A38", VA = "0x46E4A38")]
	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CCA")]
	[Address(RVA = "0x46E4B20", Offset = "0x46E4B20", VA = "0x46E4B20")]
	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CCB")]
	[Address(RVA = "0x46E4C08", Offset = "0x46E4C08", VA = "0x46E4C08")]
	public static extern bool CSharp_AkChannelConfig_IsChannelConfigSupported(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CCC")]
	[Address(RVA = "0x46E4D00", Offset = "0x46E4D00", VA = "0x46E4D00")]
	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CCD")]
	[Address(RVA = "0x46E4DE0", Offset = "0x46E4DE0", VA = "0x46E4DE0")]
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018CCE")]
	[Address(RVA = "0x46E4EC0", Offset = "0x46E4EC0", VA = "0x46E4EC0")]
	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(IntPtr jarg1, float jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CCF")]
	[Address(RVA = "0x46E4FB8", Offset = "0x46E4FB8", VA = "0x46E4FB8")]
	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CD0")]
	[Address(RVA = "0x46E50B0", Offset = "0x46E50B0", VA = "0x46E50B0")]
	public static extern IntPtr CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CD1")]
	[Address(RVA = "0x46E51A0", Offset = "0x46E51A0", VA = "0x46E51A0")]
	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CD2")]
	[Address(RVA = "0x46E52A0", Offset = "0x46E52A0", VA = "0x46E52A0")]
	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CD3")]
	[Address(RVA = "0x46E5398", Offset = "0x46E5398", VA = "0x46E5398")]
	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CD4")]
	[Address(RVA = "0x46E5488", Offset = "0x46E5488", VA = "0x46E5488")]
	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CD5")]
	[Address(RVA = "0x46E5570", Offset = "0x46E5570", VA = "0x46E5570")]
	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CD6")]
	[Address(RVA = "0x46E5668", Offset = "0x46E5668", VA = "0x46E5668")]
	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CD7")]
	[Address(RVA = "0x46E5758", Offset = "0x46E5758", VA = "0x46E5758")]
	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CD8")]
	[Address(RVA = "0x46E5858", Offset = "0x46E5858", VA = "0x46E5858")]
	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CD9")]
	[Address(RVA = "0x46E5950", Offset = "0x46E5950", VA = "0x46E5950")]
	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CDA")]
	[Address(RVA = "0x46E5A50", Offset = "0x46E5A50", VA = "0x46E5A50")]
	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CDB")]
	[Address(RVA = "0x46E5B48", Offset = "0x46E5B48", VA = "0x46E5B48")]
	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CDC")]
	[Address(RVA = "0x46E5C30", Offset = "0x46E5C30", VA = "0x46E5C30")]
	public static extern float CSharp_kDefaultMaxPathLength_get();

	[PreserveSig]
	[Token(Token = "0x6018CDD")]
	[Address(RVA = "0x46E5D10", Offset = "0x46E5D10", VA = "0x46E5D10")]
	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get();

	[PreserveSig]
	[Token(Token = "0x6018CDE")]
	[Address(RVA = "0x46E5DF0", Offset = "0x46E5DF0", VA = "0x46E5DF0")]
	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get();

	[PreserveSig]
	[Token(Token = "0x6018CDF")]
	[Address(RVA = "0x46E5ED0", Offset = "0x46E5ED0", VA = "0x46E5ED0")]
	public static extern float CSharp_kMaxDiffraction_get();

	[PreserveSig]
	[Token(Token = "0x6018CE0")]
	[Address(RVA = "0x46E5FA8", Offset = "0x46E5FA8", VA = "0x46E5FA8")]
	public static extern uint CSharp_kListenerDiffractionMaxEdges_get();

	[PreserveSig]
	[Token(Token = "0x6018CE1")]
	[Address(RVA = "0x46E6088", Offset = "0x46E6088", VA = "0x46E6088")]
	public static extern uint CSharp_kListenerDiffractionMaxPaths_get();

	[PreserveSig]
	[Token(Token = "0x6018CE2")]
	[Address(RVA = "0x46E6168", Offset = "0x46E6168", VA = "0x46E6168")]
	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get();

	[PreserveSig]
	[Token(Token = "0x6018CE3")]
	[Address(RVA = "0x46E6250", Offset = "0x46E6250", VA = "0x46E6250")]
	public static extern void CSharp_g_SpatialAudioPoolId_set(int jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CE4")]
	[Address(RVA = "0x46E6330", Offset = "0x46E6330", VA = "0x46E6330")]
	public static extern int CSharp_g_SpatialAudioPoolId_get();

	[PreserveSig]
	[Token(Token = "0x6018CE5")]
	[Address(RVA = "0x46E6408", Offset = "0x46E6408", VA = "0x46E6408")]
	public static extern int CSharp__ArrayPoolSpatialAudio_Get();

	[PreserveSig]
	[Token(Token = "0x6018CE6")]
	[Address(RVA = "0x46E64E8", Offset = "0x46E64E8", VA = "0x46E64E8")]
	public static extern IntPtr CSharp_new__ArrayPoolSpatialAudio();

	[PreserveSig]
	[Token(Token = "0x6018CE7")]
	[Address(RVA = "0x46E65C8", Offset = "0x46E65C8", VA = "0x46E65C8")]
	public static extern void CSharp_delete__ArrayPoolSpatialAudio(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CE8")]
	[Address(RVA = "0x46E66B0", Offset = "0x46E66B0", VA = "0x46E66B0")]
	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings();

	[PreserveSig]
	[Token(Token = "0x6018CE9")]
	[Address(RVA = "0x46E6790", Offset = "0x46E6790", VA = "0x46E6790")]
	public static extern void CSharp_AkSpatialAudioInitSettings_uPoolID_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CEA")]
	[Address(RVA = "0x46E6888", Offset = "0x46E6888", VA = "0x46E6888")]
	public static extern int CSharp_AkSpatialAudioInitSettings_uPoolID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CEB")]
	[Address(RVA = "0x46E6978", Offset = "0x46E6978", VA = "0x46E6978")]
	public static extern void CSharp_AkSpatialAudioInitSettings_uPoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CEC")]
	[Address(RVA = "0x46E6A70", Offset = "0x46E6A70", VA = "0x46E6A70")]
	public static extern uint CSharp_AkSpatialAudioInitSettings_uPoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CED")]
	[Address(RVA = "0x46E6B60", Offset = "0x46E6B60", VA = "0x46E6B60")]
	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CEE")]
	[Address(RVA = "0x46E6C68", Offset = "0x46E6C68", VA = "0x46E6C68")]
	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CEF")]
	[Address(RVA = "0x46E6D68", Offset = "0x46E6D68", VA = "0x46E6D68")]
	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CF0")]
	[Address(RVA = "0x46E6E68", Offset = "0x46E6E68", VA = "0x46E6E68")]
	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CF1")]
	[Address(RVA = "0x46E6F60", Offset = "0x46E6F60", VA = "0x46E6F60")]
	public static extern void CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CF2")]
	[Address(RVA = "0x46E7038", Offset = "0x46E7038", VA = "0x46E7038")]
	public static extern float CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CF3")]
	[Address(RVA = "0x46E7108", Offset = "0x46E7108", VA = "0x46E7108")]
	public static extern void CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CF4")]
	[Address(RVA = "0x46E7210", Offset = "0x46E7210", VA = "0x46E7210")]
	public static extern float CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CF5")]
	[Address(RVA = "0x46E7310", Offset = "0x46E7310", VA = "0x46E7310")]
	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CF6")]
	[Address(RVA = "0x46E7418", Offset = "0x46E7418", VA = "0x46E7418")]
	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CF7")]
	[Address(RVA = "0x46E7518", Offset = "0x46E7518", VA = "0x46E7518")]
	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CF8")]
	[Address(RVA = "0x46E7608", Offset = "0x46E7608", VA = "0x46E7608")]
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018CF9")]
	[Address(RVA = "0x46E76F0", Offset = "0x46E76F0", VA = "0x46E76F0")]
	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(IntPtr jarg1, float jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018CFA")]
	[Address(RVA = "0x46E77F0", Offset = "0x46E77F0", VA = "0x46E77F0")]
	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CFB")]
	[Address(RVA = "0x46E78D8", Offset = "0x46E78D8", VA = "0x46E78D8")]
	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CFC")]
	[Address(RVA = "0x46E79D0", Offset = "0x46E79D0", VA = "0x46E79D0")]
	public static extern void CSharp_AkImageSourceSettings_SetName(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CFD")]
	[Address(RVA = "0x46E7AE0", Offset = "0x46E7AE0", VA = "0x46E7AE0")]
	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018CFE")]
	[Address(RVA = "0x46E7BD8", Offset = "0x46E7BD8", VA = "0x46E7BD8")]
	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018CFF")]
	[Address(RVA = "0x46E7CC8", Offset = "0x46E7CC8", VA = "0x46E7CC8")]
	public static extern IntPtr CSharp_new_AkEmitterSettings();

	[PreserveSig]
	[Token(Token = "0x6018D00")]
	[Address(RVA = "0x46E7DA0", Offset = "0x46E7DA0", VA = "0x46E7DA0")]
	public static extern void CSharp_AkEmitterSettings_reflectAuxBusID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D01")]
	[Address(RVA = "0x46E7E98", Offset = "0x46E7E98", VA = "0x46E7E98")]
	public static extern uint CSharp_AkEmitterSettings_reflectAuxBusID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D02")]
	[Address(RVA = "0x46E7F88", Offset = "0x46E7F88", VA = "0x46E7F88")]
	public static extern void CSharp_AkEmitterSettings_reflectionMaxPathLength_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D03")]
	[Address(RVA = "0x46E8088", Offset = "0x46E8088", VA = "0x46E8088")]
	public static extern float CSharp_AkEmitterSettings_reflectionMaxPathLength_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D04")]
	[Address(RVA = "0x46E8180", Offset = "0x46E8180", VA = "0x46E8180")]
	public static extern void CSharp_AkEmitterSettings_reflectionsAuxBusGain_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D05")]
	[Address(RVA = "0x46E8280", Offset = "0x46E8280", VA = "0x46E8280")]
	public static extern float CSharp_AkEmitterSettings_reflectionsAuxBusGain_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D06")]
	[Address(RVA = "0x46E8378", Offset = "0x46E8378", VA = "0x46E8378")]
	public static extern void CSharp_AkEmitterSettings_reflectionsOrder_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D07")]
	[Address(RVA = "0x46E8470", Offset = "0x46E8470", VA = "0x46E8470")]
	public static extern uint CSharp_AkEmitterSettings_reflectionsOrder_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D08")]
	[Address(RVA = "0x46E8560", Offset = "0x46E8560", VA = "0x46E8560")]
	public static extern void CSharp_AkEmitterSettings_reflectorFilterMask_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D09")]
	[Address(RVA = "0x46E8660", Offset = "0x46E8660", VA = "0x46E8660")]
	public static extern uint CSharp_AkEmitterSettings_reflectorFilterMask_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D0A")]
	[Address(RVA = "0x46E8758", Offset = "0x46E8758", VA = "0x46E8758")]
	public static extern void CSharp_AkEmitterSettings_roomReverbAuxBusGain_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D0B")]
	[Address(RVA = "0x46E8858", Offset = "0x46E8858", VA = "0x46E8858")]
	public static extern float CSharp_AkEmitterSettings_roomReverbAuxBusGain_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D0C")]
	[Address(RVA = "0x46E8950", Offset = "0x46E8950", VA = "0x46E8950")]
	public static extern void CSharp_AkEmitterSettings_diffractionMaxEdges_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D0D")]
	[Address(RVA = "0x46E8A50", Offset = "0x46E8A50", VA = "0x46E8A50")]
	public static extern uint CSharp_AkEmitterSettings_diffractionMaxEdges_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D0E")]
	[Address(RVA = "0x46E8B48", Offset = "0x46E8B48", VA = "0x46E8B48")]
	public static extern void CSharp_AkEmitterSettings_diffractionMaxPaths_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D0F")]
	[Address(RVA = "0x46E8C48", Offset = "0x46E8C48", VA = "0x46E8C48")]
	public static extern uint CSharp_AkEmitterSettings_diffractionMaxPaths_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D10")]
	[Address(RVA = "0x46E8D40", Offset = "0x46E8D40", VA = "0x46E8D40")]
	public static extern void CSharp_AkEmitterSettings_diffractionMaxPathLength_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D11")]
	[Address(RVA = "0x46E8E40", Offset = "0x46E8E40", VA = "0x46E8E40")]
	public static extern float CSharp_AkEmitterSettings_diffractionMaxPathLength_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D12")]
	[Address(RVA = "0x46E8F38", Offset = "0x46E8F38", VA = "0x46E8F38")]
	public static extern void CSharp_AkEmitterSettings_useImageSources_set(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D13")]
	[Address(RVA = "0x46E9030", Offset = "0x46E9030", VA = "0x46E9030")]
	public static extern byte CSharp_AkEmitterSettings_useImageSources_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D14")]
	[Address(RVA = "0x46E9120", Offset = "0x46E9120", VA = "0x46E9120")]
	public static extern void CSharp_delete_AkEmitterSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D15")]
	[Address(RVA = "0x46E9200", Offset = "0x46E9200", VA = "0x46E9200")]
	public static extern IntPtr CSharp_new_AkVertex__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018D16")]
	[Address(RVA = "0x46E92D8", Offset = "0x46E92D8", VA = "0x46E92D8")]
	public static extern IntPtr CSharp_new_AkVertex__SWIG_1(float jarg1, float jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018D17")]
	[Address(RVA = "0x46E93C8", Offset = "0x46E93C8", VA = "0x46E93C8")]
	public static extern void CSharp_AkVertex_X_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D18")]
	[Address(RVA = "0x46E94E0", Offset = "0x46E94E0", VA = "0x46E94E0")]
	public static extern float CSharp_AkVertex_X_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D19")]
	[Address(RVA = "0x46E95F0", Offset = "0x46E95F0", VA = "0x46E95F0")]
	public static extern void CSharp_AkVertex_Y_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D1A")]
	[Address(RVA = "0x46E9708", Offset = "0x46E9708", VA = "0x46E9708")]
	public static extern float CSharp_AkVertex_Y_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D1B")]
	[Address(RVA = "0x46E9818", Offset = "0x46E9818", VA = "0x46E9818")]
	public static extern void CSharp_AkVertex_Z_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D1C")]
	[Address(RVA = "0x46E9930", Offset = "0x46E9930", VA = "0x46E9930")]
	public static extern float CSharp_AkVertex_Z_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D1D")]
	[Address(RVA = "0x46E9A40", Offset = "0x46E9A40", VA = "0x46E9A40")]
	public static extern void CSharp_AkVertex_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D1E")]
	[Address(RVA = "0x46E9B50", Offset = "0x46E9B50", VA = "0x46E9B50")]
	public static extern int CSharp_AkVertex_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018D1F")]
	[Address(RVA = "0x46E9C58", Offset = "0x46E9C58", VA = "0x46E9C58")]
	public static extern void CSharp_AkVertex_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D20")]
	[Address(RVA = "0x46E9D70", Offset = "0x46E9D70", VA = "0x46E9D70")]
	public static extern void CSharp_delete_AkVertex(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D21")]
	[Address(RVA = "0x46E9E88", Offset = "0x46E9E88", VA = "0x46E9E88")]
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018D22")]
	[Address(RVA = "0x46E9F60", Offset = "0x46E9F60", VA = "0x46E9F60")]
	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4);

	[PreserveSig]
	[Token(Token = "0x6018D23")]
	[Address(RVA = "0x46EA058", Offset = "0x46EA058", VA = "0x46EA058")]
	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D24")]
	[Address(RVA = "0x46EA140", Offset = "0x46EA140", VA = "0x46EA140")]
	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D25")]
	[Address(RVA = "0x46EA220", Offset = "0x46EA220", VA = "0x46EA220")]
	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D26")]
	[Address(RVA = "0x46EA308", Offset = "0x46EA308", VA = "0x46EA308")]
	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D27")]
	[Address(RVA = "0x46EA3E8", Offset = "0x46EA3E8", VA = "0x46EA3E8")]
	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D28")]
	[Address(RVA = "0x46EA4D0", Offset = "0x46EA4D0", VA = "0x46EA4D0")]
	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D29")]
	[Address(RVA = "0x46EA5B0", Offset = "0x46EA5B0", VA = "0x46EA5B0")]
	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D2A")]
	[Address(RVA = "0x46EA698", Offset = "0x46EA698", VA = "0x46EA698")]
	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D2B")]
	[Address(RVA = "0x46EA778", Offset = "0x46EA778", VA = "0x46EA778")]
	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D2C")]
	[Address(RVA = "0x46EA890", Offset = "0x46EA890", VA = "0x46EA890")]
	public static extern int CSharp_AkTriangle_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018D2D")]
	[Address(RVA = "0x46EA968", Offset = "0x46EA968", VA = "0x46EA968")]
	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D2E")]
	[Address(RVA = "0x46EAA88", Offset = "0x46EAA88", VA = "0x46EAA88")]
	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D2F")]
	[Address(RVA = "0x46EABA0", Offset = "0x46EABA0", VA = "0x46EABA0")]
	public static extern IntPtr CSharp_new_AkAcousticSurface();

	[PreserveSig]
	[Token(Token = "0x6018D30")]
	[Address(RVA = "0x46EAC78", Offset = "0x46EAC78", VA = "0x46EAC78")]
	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D31")]
	[Address(RVA = "0x46EAD68", Offset = "0x46EAD68", VA = "0x46EAD68")]
	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D32")]
	[Address(RVA = "0x46EAE50", Offset = "0x46EAE50", VA = "0x46EAE50")]
	public static extern void CSharp_AkAcousticSurface_reflectorChannelMask_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D33")]
	[Address(RVA = "0x46EAF50", Offset = "0x46EAF50", VA = "0x46EAF50")]
	public static extern uint CSharp_AkAcousticSurface_reflectorChannelMask_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D34")]
	[Address(RVA = "0x46EB048", Offset = "0x46EB048", VA = "0x46EB048")]
	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D35")]
	[Address(RVA = "0x46EB158", Offset = "0x46EB158", VA = "0x46EB158")]
	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D36")]
	[Address(RVA = "0x46EB240", Offset = "0x46EB240", VA = "0x46EB240")]
	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D37")]
	[Address(RVA = "0x46EB320", Offset = "0x46EB320", VA = "0x46EB320")]
	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D38")]
	[Address(RVA = "0x46EB408", Offset = "0x46EB408", VA = "0x46EB408")]
	public static extern int CSharp_AkAcousticSurface_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018D39")]
	[Address(RVA = "0x46EB4E8", Offset = "0x46EB4E8", VA = "0x46EB4E8")]
	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D3A")]
	[Address(RVA = "0x46EB5D0", Offset = "0x46EB5D0", VA = "0x46EB5D0")]
	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D3B")]
	[Address(RVA = "0x46EB6B0", Offset = "0x46EB6B0", VA = "0x46EB6B0")]
	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D3C")]
	[Address(RVA = "0x46EB7A8", Offset = "0x46EB7A8", VA = "0x46EB7A8")]
	public static extern IntPtr CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D3D")]
	[Address(RVA = "0x46EB898", Offset = "0x46EB898", VA = "0x46EB898")]
	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D3E")]
	[Address(RVA = "0x46EB990", Offset = "0x46EB990", VA = "0x46EB990")]
	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D3F")]
	[Address(RVA = "0x46EBA80", Offset = "0x46EBA80", VA = "0x46EBA80")]
	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D40")]
	[Address(RVA = "0x46EBB78", Offset = "0x46EBB78", VA = "0x46EBB78")]
	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D41")]
	[Address(RVA = "0x46EBC68", Offset = "0x46EBC68", VA = "0x46EBC68")]
	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D42")]
	[Address(RVA = "0x46EBD58", Offset = "0x46EBD58", VA = "0x46EBD58")]
	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D43")]
	[Address(RVA = "0x46EBE40", Offset = "0x46EBE40", VA = "0x46EBE40")]
	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D44")]
	[Address(RVA = "0x46EBF38", Offset = "0x46EBF38", VA = "0x46EBF38")]
	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D45")]
	[Address(RVA = "0x46EC030", Offset = "0x46EC030", VA = "0x46EC030")]
	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018D46")]
	[Address(RVA = "0x46EC110", Offset = "0x46EC110", VA = "0x46EC110")]
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D47")]
	[Address(RVA = "0x46EC208", Offset = "0x46EC208", VA = "0x46EC208")]
	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D48")]
	[Address(RVA = "0x46EC300", Offset = "0x46EC300", VA = "0x46EC300")]
	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D49")]
	[Address(RVA = "0x46EC3F8", Offset = "0x46EC3F8", VA = "0x46EC3F8")]
	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D4A")]
	[Address(RVA = "0x46EC4E8", Offset = "0x46EC4E8", VA = "0x46EC4E8")]
	public static extern IntPtr CSharp_new_AkReflectionPathInfo();

	[PreserveSig]
	[Token(Token = "0x6018D4B")]
	[Address(RVA = "0x46EC5C0", Offset = "0x46EC5C0", VA = "0x46EC5C0")]
	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D4C")]
	[Address(RVA = "0x46EC6A8", Offset = "0x46EC6A8", VA = "0x46EC6A8")]
	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D4D")]
	[Address(RVA = "0x46EC7A0", Offset = "0x46EC7A0", VA = "0x46EC7A0")]
	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D4E")]
	[Address(RVA = "0x46EC890", Offset = "0x46EC890", VA = "0x46EC890")]
	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D4F")]
	[Address(RVA = "0x46EC988", Offset = "0x46EC988", VA = "0x46EC988")]
	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D50")]
	[Address(RVA = "0x46ECA78", Offset = "0x46ECA78", VA = "0x46ECA78")]
	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D51")]
	[Address(RVA = "0x46ECB70", Offset = "0x46ECB70", VA = "0x46ECB70")]
	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D52")]
	[Address(RVA = "0x46ECC60", Offset = "0x46ECC60", VA = "0x46ECC60")]
	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D53")]
	[Address(RVA = "0x46ECD58", Offset = "0x46ECD58", VA = "0x46ECD58")]
	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D54")]
	[Address(RVA = "0x46ECE48", Offset = "0x46ECE48", VA = "0x46ECE48")]
	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D55")]
	[Address(RVA = "0x46ECF48", Offset = "0x46ECF48", VA = "0x46ECF48")]
	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D56")]
	[Address(RVA = "0x46ED040", Offset = "0x46ED040", VA = "0x46ED040")]
	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018D57")]
	[Address(RVA = "0x46ED120", Offset = "0x46ED120", VA = "0x46ED120")]
	public static extern IntPtr CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D58")]
	[Address(RVA = "0x46ED210", Offset = "0x46ED210", VA = "0x46ED210")]
	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D59")]
	[Address(RVA = "0x46ED300", Offset = "0x46ED300", VA = "0x46ED300")]
	public static extern ulong CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D5A")]
	[Address(RVA = "0x46ED3F0", Offset = "0x46ED3F0", VA = "0x46ED3F0")]
	public static extern ulong CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D5B")]
	[Address(RVA = "0x46ED4E0", Offset = "0x46ED4E0", VA = "0x46ED4E0")]
	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D5C")]
	[Address(RVA = "0x46ED5D0", Offset = "0x46ED5D0", VA = "0x46ED5D0")]
	public static extern IntPtr CSharp_new_AkDiffractionPathInfo();

	[PreserveSig]
	[Token(Token = "0x6018D5D")]
	[Address(RVA = "0x46ED6B0", Offset = "0x46ED6B0", VA = "0x46ED6B0")]
	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D5E")]
	[Address(RVA = "0x46ED798", Offset = "0x46ED798", VA = "0x46ED798")]
	public static extern IntPtr CSharp_new_AkRoomParams();

	[PreserveSig]
	[Token(Token = "0x6018D5F")]
	[Address(RVA = "0x46ED8A0", Offset = "0x46ED8A0", VA = "0x46ED8A0")]
	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D60")]
	[Address(RVA = "0x46ED988", Offset = "0x46ED988", VA = "0x46ED988")]
	public static extern IntPtr CSharp_AkRoomParams_Up_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D61")]
	[Address(RVA = "0x46EDA68", Offset = "0x46EDA68", VA = "0x46EDA68")]
	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D62")]
	[Address(RVA = "0x46EDB50", Offset = "0x46EDB50", VA = "0x46EDB50")]
	public static extern IntPtr CSharp_AkRoomParams_Front_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D63")]
	[Address(RVA = "0x46EDC30", Offset = "0x46EDC30", VA = "0x46EDC30")]
	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D64")]
	[Address(RVA = "0x46EDD20", Offset = "0x46EDD20", VA = "0x46EDD20")]
	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D65")]
	[Address(RVA = "0x46EDE08", Offset = "0x46EDE08", VA = "0x46EDE08")]
	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D66")]
	[Address(RVA = "0x46EDEF8", Offset = "0x46EDEF8", VA = "0x46EDEF8")]
	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D67")]
	[Address(RVA = "0x46EDFE0", Offset = "0x46EDFE0", VA = "0x46EDFE0")]
	public static extern void CSharp_AkRoomParams_WallOcclusion_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D68")]
	[Address(RVA = "0x46EE0D0", Offset = "0x46EE0D0", VA = "0x46EE0D0")]
	public static extern float CSharp_AkRoomParams_WallOcclusion_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D69")]
	[Address(RVA = "0x46EE1B8", Offset = "0x46EE1B8", VA = "0x46EE1B8")]
	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D6A")]
	[Address(RVA = "0x46EE2B8", Offset = "0x46EE2B8", VA = "0x46EE2B8")]
	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D6B")]
	[Address(RVA = "0x46EE3B0", Offset = "0x46EE3B0", VA = "0x46EE3B0")]
	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D6C")]
	[Address(RVA = "0x46EE4B0", Offset = "0x46EE4B0", VA = "0x46EE4B0")]
	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D6D")]
	[Address(RVA = "0x46EE5B0", Offset = "0x46EE5B0", VA = "0x46EE5B0")]
	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D6E")]
	[Address(RVA = "0x46EE690", Offset = "0x46EE690", VA = "0x46EE690")]
	public static extern int CSharp_GetPoolID();

	[PreserveSig]
	[Token(Token = "0x6018D6F")]
	[Address(RVA = "0x46EE788", Offset = "0x46EE788", VA = "0x46EE788")]
	public static extern int CSharp_RegisterEmitter(ulong jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D70")]
	[Address(RVA = "0x46EE8B0", Offset = "0x46EE8B0", VA = "0x46EE8B0")]
	public static extern int CSharp_UnregisterEmitter(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D71")]
	[Address(RVA = "0x46EE9D0", Offset = "0x46EE9D0", VA = "0x46EE9D0")]
	public static extern int CSharp_SetEmitterAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018D72")]
	[Address(RVA = "0x46EEAC8", Offset = "0x46EEAC8", VA = "0x46EEAC8")]
	public static extern int CSharp_SetImageSource__SWIG_0(uint jarg1, IntPtr jarg2, uint jarg3, ulong jarg4, ulong jarg5);

	[PreserveSig]
	[Token(Token = "0x6018D73")]
	[Address(RVA = "0x46EEBD8", Offset = "0x46EEBD8", VA = "0x46EEBD8")]
	public static extern int CSharp_SetImageSource__SWIG_1(uint jarg1, IntPtr jarg2, uint jarg3, ulong jarg4);

	[PreserveSig]
	[Token(Token = "0x6018D74")]
	[Address(RVA = "0x46EECD8", Offset = "0x46EECD8", VA = "0x46EECD8")]
	public static extern int CSharp_RemoveImageSource__SWIG_0(uint jarg1, uint jarg2, ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6018D75")]
	[Address(RVA = "0x46EEDD8", Offset = "0x46EEDD8", VA = "0x46EEDD8")]
	public static extern int CSharp_RemoveImageSource__SWIG_1(uint jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D76")]
	[Address(RVA = "0x46EEEC8", Offset = "0x46EEEC8", VA = "0x46EEEC8")]
	public static extern int CSharp_RemoveGeometry(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D77")]
	[Address(RVA = "0x46EEFE0", Offset = "0x46EEFE0", VA = "0x46EEFE0")]
	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6018D78")]
	[Address(RVA = "0x46EF0E8", Offset = "0x46EF0E8", VA = "0x46EF0E8")]
	public static extern int CSharp_RemoveRoom(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D79")]
	[Address(RVA = "0x46EF1F8", Offset = "0x46EF1F8", VA = "0x46EF1F8")]
	public static extern int CSharp_RemovePortal(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D7A")]
	[Address(RVA = "0x46EF310", Offset = "0x46EF310", VA = "0x46EF310")]
	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D7B")]
	[Address(RVA = "0x46EF408", Offset = "0x46EF408", VA = "0x46EF408")]
	public static extern int CSharp_SetEmitterObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018D7C")]
	[Address(RVA = "0x46EF510", Offset = "0x46EF510", VA = "0x46EF510")]
	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3);

	[PreserveSig]
	[Token(Token = "0x6018D7D")]
	[Address(RVA = "0x46EF610", Offset = "0x46EF610", VA = "0x46EF610")]
	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D7E")]
	[Address(RVA = "0x46EF700", Offset = "0x46EF700", VA = "0x46EF700")]
	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D7F")]
	[Address(RVA = "0x46EF7F8", Offset = "0x46EF7F8", VA = "0x46EF7F8")]
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D80")]
	[Address(RVA = "0x46EF8E8", Offset = "0x46EF8E8", VA = "0x46EF8E8")]
	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D81")]
	[Address(RVA = "0x46EF9E8", Offset = "0x46EF9E8", VA = "0x46EF9E8")]
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D82")]
	[Address(RVA = "0x46EFAE0", Offset = "0x46EFAE0", VA = "0x46EFAE0")]
	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D83")]
	[Address(RVA = "0x46EFBE0", Offset = "0x46EFBE0", VA = "0x46EFBE0")]
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D84")]
	[Address(RVA = "0x46EFCD8", Offset = "0x46EFCD8", VA = "0x46EFCD8")]
	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D85")]
	[Address(RVA = "0x46EFDD0", Offset = "0x46EFDD0", VA = "0x46EFDD0")]
	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D86")]
	[Address(RVA = "0x46EFEC0", Offset = "0x46EFEC0", VA = "0x46EFEC0")]
	public static extern void CSharp_AkPlatformInitSettings_fLEngineDefaultPoolRatioThreshold_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D87")]
	[Address(RVA = "0x46EFF98", Offset = "0x46EFF98", VA = "0x46EFF98")]
	public static extern float CSharp_AkPlatformInitSettings_fLEngineDefaultPoolRatioThreshold_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D88")]
	[Address(RVA = "0x46F0068", Offset = "0x46F0068", VA = "0x46F0068")]
	public static extern void CSharp_AkPlatformInitSettings_uLEngineDefaultPoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D89")]
	[Address(RVA = "0x46F0170", Offset = "0x46F0170", VA = "0x46F0170")]
	public static extern uint CSharp_AkPlatformInitSettings_uLEngineDefaultPoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D8A")]
	[Address(RVA = "0x46F0270", Offset = "0x46F0270", VA = "0x46F0270")]
	public static extern void CSharp_AkPlatformInitSettings_eAudioAPI_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D8B")]
	[Address(RVA = "0x46F0368", Offset = "0x46F0368", VA = "0x46F0368")]
	public static extern int CSharp_AkPlatformInitSettings_eAudioAPI_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D8C")]
	[Address(RVA = "0x46F0458", Offset = "0x46F0458", VA = "0x46F0458")]
	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D8D")]
	[Address(RVA = "0x46F0550", Offset = "0x46F0550", VA = "0x46F0550")]
	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D8E")]
	[Address(RVA = "0x46F0640", Offset = "0x46F0640", VA = "0x46F0640")]
	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D8F")]
	[Address(RVA = "0x46F0740", Offset = "0x46F0740", VA = "0x46F0740")]
	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D90")]
	[Address(RVA = "0x46F0838", Offset = "0x46F0838", VA = "0x46F0838")]
	public static extern void CSharp_AkPlatformInitSettings_uChannelMask_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D91")]
	[Address(RVA = "0x46F0930", Offset = "0x46F0930", VA = "0x46F0930")]
	public static extern uint CSharp_AkPlatformInitSettings_uChannelMask_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D92")]
	[Address(RVA = "0x46F0A20", Offset = "0x46F0A20", VA = "0x46F0A20")]
	public static extern void CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D93")]
	[Address(RVA = "0x46F0B28", Offset = "0x46F0B28", VA = "0x46F0B28")]
	public static extern bool CSharp_AkPlatformInitSettings_bRoundFrameSizeToHWSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D94")]
	[Address(RVA = "0x46F0C30", Offset = "0x46F0C30", VA = "0x46F0C30")]
	public static extern IntPtr CSharp_new_AkPlatformInitSettings();

	[PreserveSig]
	[Token(Token = "0x6018D95")]
	[Address(RVA = "0x46F0D10", Offset = "0x46F0D10", VA = "0x46F0D10")]
	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D96")]
	[Address(RVA = "0x46F0DF8", Offset = "0x46F0DF8", VA = "0x46F0DF8")]
	public static extern int CSharp_GetFastPathSettings(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D97")]
	[Address(RVA = "0x46F0EE0", Offset = "0x46F0EE0", VA = "0x46F0EE0")]
	public static extern void CSharp_AkStreamMgrSettings_uMemorySize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D98")]
	[Address(RVA = "0x46F0FD8", Offset = "0x46F0FD8", VA = "0x46F0FD8")]
	public static extern uint CSharp_AkStreamMgrSettings_uMemorySize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D99")]
	[Address(RVA = "0x46F10C8", Offset = "0x46F10C8", VA = "0x46F10C8")]
	public static extern IntPtr CSharp_new_AkStreamMgrSettings();

	[PreserveSig]
	[Token(Token = "0x6018D9A")]
	[Address(RVA = "0x46F11A0", Offset = "0x46F11A0", VA = "0x46F11A0")]
	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D9B")]
	[Address(RVA = "0x46F1288", Offset = "0x46F1288", VA = "0x46F1288")]
	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D9C")]
	[Address(RVA = "0x46F1378", Offset = "0x46F1378", VA = "0x46F1378")]
	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D9D")]
	[Address(RVA = "0x46F1460", Offset = "0x46F1460", VA = "0x46F1460")]
	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018D9E")]
	[Address(RVA = "0x46F1558", Offset = "0x46F1558", VA = "0x46F1558")]
	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018D9F")]
	[Address(RVA = "0x46F1648", Offset = "0x46F1648", VA = "0x46F1648")]
	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DA0")]
	[Address(RVA = "0x46F1740", Offset = "0x46F1740", VA = "0x46F1740")]
	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DA1")]
	[Address(RVA = "0x46F1830", Offset = "0x46F1830", VA = "0x46F1830")]
	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DA2")]
	[Address(RVA = "0x46F1928", Offset = "0x46F1928", VA = "0x46F1928")]
	public static extern int CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DA3")]
	[Address(RVA = "0x46F1A18", Offset = "0x46F1A18", VA = "0x46F1A18")]
	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DA4")]
	[Address(RVA = "0x46F1B10", Offset = "0x46F1B10", VA = "0x46F1B10")]
	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DA5")]
	[Address(RVA = "0x46F1C00", Offset = "0x46F1C00", VA = "0x46F1C00")]
	public static extern void CSharp_AkDeviceSettings_uSchedulerTypeFlags_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DA6")]
	[Address(RVA = "0x46F1CF8", Offset = "0x46F1CF8", VA = "0x46F1CF8")]
	public static extern uint CSharp_AkDeviceSettings_uSchedulerTypeFlags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DA7")]
	[Address(RVA = "0x46F1DE8", Offset = "0x46F1DE8", VA = "0x46F1DE8")]
	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DA8")]
	[Address(RVA = "0x46F1EE0", Offset = "0x46F1EE0", VA = "0x46F1EE0")]
	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DA9")]
	[Address(RVA = "0x46F1FD0", Offset = "0x46F1FD0", VA = "0x46F1FD0")]
	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DAA")]
	[Address(RVA = "0x46F20D0", Offset = "0x46F20D0", VA = "0x46F20D0")]
	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DAB")]
	[Address(RVA = "0x46F21C8", Offset = "0x46F21C8", VA = "0x46F21C8")]
	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DAC")]
	[Address(RVA = "0x46F22C0", Offset = "0x46F22C0", VA = "0x46F22C0")]
	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DAD")]
	[Address(RVA = "0x46F23B0", Offset = "0x46F23B0", VA = "0x46F23B0")]
	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DAE")]
	[Address(RVA = "0x46F24A8", Offset = "0x46F24A8", VA = "0x46F24A8")]
	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DAF")]
	[Address(RVA = "0x46F25A0", Offset = "0x46F25A0", VA = "0x46F25A0")]
	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DB0")]
	[Address(RVA = "0x46F26A0", Offset = "0x46F26A0", VA = "0x46F26A0")]
	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DB1")]
	[Address(RVA = "0x46F2798", Offset = "0x46F2798", VA = "0x46F2798")]
	public static extern IntPtr CSharp_new_AkDeviceSettings();

	[PreserveSig]
	[Token(Token = "0x6018DB2")]
	[Address(RVA = "0x46F2870", Offset = "0x46F2870", VA = "0x46F2870")]
	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DB3")]
	[Address(RVA = "0x46F2950", Offset = "0x46F2950", VA = "0x46F2950")]
	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DB4")]
	[Address(RVA = "0x46F2A40", Offset = "0x46F2A40", VA = "0x46F2A40")]
	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DB5")]
	[Address(RVA = "0x46F2B28", Offset = "0x46F2B28", VA = "0x46F2B28")]
	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DB6")]
	[Address(RVA = "0x46F2C20", Offset = "0x46F2C20", VA = "0x46F2C20")]
	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DB7")]
	[Address(RVA = "0x46F2D10", Offset = "0x46F2D10", VA = "0x46F2D10")]
	public static extern void CSharp_AkThreadProperties_uSchedPolicy_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DB8")]
	[Address(RVA = "0x46F2E08", Offset = "0x46F2E08", VA = "0x46F2E08")]
	public static extern int CSharp_AkThreadProperties_uSchedPolicy_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DB9")]
	[Address(RVA = "0x46F2EF8", Offset = "0x46F2EF8", VA = "0x46F2EF8")]
	public static extern void CSharp_AkThreadProperties_dwAffinityMask_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DBA")]
	[Address(RVA = "0x46F2FF0", Offset = "0x46F2FF0", VA = "0x46F2FF0")]
	public static extern uint CSharp_AkThreadProperties_dwAffinityMask_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DBB")]
	[Address(RVA = "0x46F30E0", Offset = "0x46F30E0", VA = "0x46F30E0")]
	public static extern IntPtr CSharp_new_AkThreadProperties();

	[PreserveSig]
	[Token(Token = "0x6018DBC")]
	[Address(RVA = "0x46F31B8", Offset = "0x46F31B8", VA = "0x46F31B8")]
	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DBD")]
	[Address(RVA = "0x46F32A0", Offset = "0x46F32A0", VA = "0x46F32A0")]
	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DBE")]
	[Address(RVA = "0x46F3390", Offset = "0x46F3390", VA = "0x46F3390")]
	public static extern void CSharp_SetErrorLogger__SWIG_1();

	[PreserveSig]
	[Token(Token = "0x6018DBF")]
	[Address(RVA = "0x46F3468", Offset = "0x46F3468", VA = "0x46F3468")]
	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DC0")]
	[Address(RVA = "0x46F3570", Offset = "0x46F3570", VA = "0x46F3570")]
	public static extern void CSharp_AkPathParams_listenerPos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DC1")]
	[Address(RVA = "0x46F3660", Offset = "0x46F3660", VA = "0x46F3660")]
	public static extern IntPtr CSharp_AkPathParams_listenerPos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DC2")]
	[Address(RVA = "0x46F3748", Offset = "0x46F3748", VA = "0x46F3748")]
	public static extern void CSharp_AkPathParams_emitterPos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DC3")]
	[Address(RVA = "0x46F3838", Offset = "0x46F3838", VA = "0x46F3838")]
	public static extern IntPtr CSharp_AkPathParams_emitterPos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DC4")]
	[Address(RVA = "0x46F3920", Offset = "0x46F3920", VA = "0x46F3920")]
	public static extern void CSharp_AkPathParams_numValidPaths_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DC5")]
	[Address(RVA = "0x46F3A10", Offset = "0x46F3A10", VA = "0x46F3A10")]
	public static extern uint CSharp_AkPathParams_numValidPaths_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DC6")]
	[Address(RVA = "0x46F3AF8", Offset = "0x46F3AF8", VA = "0x46F3AF8")]
	public static extern IntPtr CSharp_new_AkPathParams();

	[PreserveSig]
	[Token(Token = "0x6018DC7")]
	[Address(RVA = "0x46F3C00", Offset = "0x46F3C00", VA = "0x46F3C00")]
	public static extern void CSharp_delete_AkPathParams(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DC8")]
	[Address(RVA = "0x46F3CE0", Offset = "0x46F3CE0", VA = "0x46F3CE0")]
	public static extern IntPtr CSharp_new_AkUnityPlatformSpecificSettings();

	[PreserveSig]
	[Token(Token = "0x6018DC9")]
	[Address(RVA = "0x46F3DC8", Offset = "0x46F3DC8", VA = "0x46F3DC8")]
	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DCA")]
	[Address(RVA = "0x46F3EB8", Offset = "0x46F3EB8", VA = "0x46F3EB8")]
	public static extern IntPtr CSharp_new_AkCommunicationSettings();

	[PreserveSig]
	[Token(Token = "0x6018DCB")]
	[Address(RVA = "0x46F3F98", Offset = "0x46F3F98", VA = "0x46F3F98")]
	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DCC")]
	[Address(RVA = "0x46F4090", Offset = "0x46F4090", VA = "0x46F4090")]
	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DCD")]
	[Address(RVA = "0x46F4180", Offset = "0x46F4180", VA = "0x46F4180")]
	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DCE")]
	[Address(RVA = "0x46F4288", Offset = "0x46F4288", VA = "0x46F4288")]
	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DCF")]
	[Address(RVA = "0x46F4388", Offset = "0x46F4388", VA = "0x46F4388")]
	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DD0")]
	[Address(RVA = "0x46F4480", Offset = "0x46F4480", VA = "0x46F4480")]
	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DD1")]
	[Address(RVA = "0x46F4570", Offset = "0x46F4570", VA = "0x46F4570")]
	public static extern void CSharp_AkCommunicationSettings_uNotificationPort_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DD2")]
	[Address(RVA = "0x46F4670", Offset = "0x46F4670", VA = "0x46F4670")]
	public static extern ushort CSharp_AkCommunicationSettings_uNotificationPort_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DD3")]
	[Address(RVA = "0x46F4768", Offset = "0x46F4768", VA = "0x46F4768")]
	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DD4")]
	[Address(RVA = "0x46F4868", Offset = "0x46F4868", VA = "0x46F4868")]
	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DD5")]
	[Address(RVA = "0x46F4968", Offset = "0x46F4968", VA = "0x46F4968")]
	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DD6")]
	[Address(RVA = "0x46F4A80", Offset = "0x46F4A80", VA = "0x46F4A80")]
	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DD7")]
	[Address(RVA = "0x46F4B78", Offset = "0x46F4B78", VA = "0x46F4B78")]
	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DD8")]
	[Address(RVA = "0x46F4C60", Offset = "0x46F4C60", VA = "0x46F4C60")]
	public static extern IntPtr CSharp_new_AkInitializationSettings();

	[PreserveSig]
	[Token(Token = "0x6018DD9")]
	[Address(RVA = "0x46F4D40", Offset = "0x46F4D40", VA = "0x46F4D40")]
	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DDA")]
	[Address(RVA = "0x46F4E28", Offset = "0x46F4E28", VA = "0x46F4E28")]
	public static extern void CSharp_AkInitializationSettings_memSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DDB")]
	[Address(RVA = "0x46F4F20", Offset = "0x46F4F20", VA = "0x46F4F20")]
	public static extern IntPtr CSharp_AkInitializationSettings_memSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DDC")]
	[Address(RVA = "0x46F5010", Offset = "0x46F5010", VA = "0x46F5010")]
	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DDD")]
	[Address(RVA = "0x46F5110", Offset = "0x46F5110", VA = "0x46F5110")]
	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DDE")]
	[Address(RVA = "0x46F5208", Offset = "0x46F5208", VA = "0x46F5208")]
	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DDF")]
	[Address(RVA = "0x46F5308", Offset = "0x46F5308", VA = "0x46F5308")]
	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DE0")]
	[Address(RVA = "0x46F5400", Offset = "0x46F5400", VA = "0x46F5400")]
	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DE1")]
	[Address(RVA = "0x46F5500", Offset = "0x46F5500", VA = "0x46F5500")]
	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DE2")]
	[Address(RVA = "0x46F55F8", Offset = "0x46F55F8", VA = "0x46F55F8")]
	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DE3")]
	[Address(RVA = "0x46F56F8", Offset = "0x46F56F8", VA = "0x46F56F8")]
	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DE4")]
	[Address(RVA = "0x46F57F0", Offset = "0x46F57F0", VA = "0x46F57F0")]
	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DE5")]
	[Address(RVA = "0x46F58F0", Offset = "0x46F58F0", VA = "0x46F58F0")]
	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DE6")]
	[Address(RVA = "0x46F59E8", Offset = "0x46F59E8", VA = "0x46F59E8")]
	public static extern void CSharp_AkInitializationSettings_preparePoolSize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DE7")]
	[Address(RVA = "0x46F5AE8", Offset = "0x46F5AE8", VA = "0x46F5AE8")]
	public static extern uint CSharp_AkInitializationSettings_preparePoolSize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DE8")]
	[Address(RVA = "0x46F5BE0", Offset = "0x46F5BE0", VA = "0x46F5BE0")]
	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DE9")]
	[Address(RVA = "0x46F5CB8", Offset = "0x46F5CB8", VA = "0x46F5CB8")]
	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DEA")]
	[Address(RVA = "0x46F5D88", Offset = "0x46F5D88", VA = "0x46F5D88")]
	public static extern void CSharp_AkInitializationSettings_useAsyncOpen_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DEB")]
	[Address(RVA = "0x46F5E88", Offset = "0x46F5E88", VA = "0x46F5E88")]
	public static extern bool CSharp_AkInitializationSettings_useAsyncOpen_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DEC")]
	[Address(RVA = "0x46F5F88", Offset = "0x46F5F88", VA = "0x46F5F88")]
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6018DED")]
	[Address(RVA = "0x46F6068", Offset = "0x46F6068", VA = "0x46F6068")]
	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DEE")]
	[Address(RVA = "0x46F6150", Offset = "0x46F6150", VA = "0x46F6150")]
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018DEF")]
	[Address(RVA = "0x46F6250", Offset = "0x46F6250", VA = "0x46F6250")]
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018DF0")]
	[Address(RVA = "0x46F6370", Offset = "0x46F6370", VA = "0x46F6370")]
	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018DF1")]
	[Address(RVA = "0x46F6468", Offset = "0x46F6468", VA = "0x46F6468")]
	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DF2")]
	[Address(RVA = "0x46F6550", Offset = "0x46F6550", VA = "0x46F6550")]
	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DF3")]
	[Address(RVA = "0x46F6640", Offset = "0x46F6640", VA = "0x46F6640")]
	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf();

	[PreserveSig]
	[Token(Token = "0x6018DF4")]
	[Address(RVA = "0x46F6720", Offset = "0x46F6720", VA = "0x46F6720")]
	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DF5")]
	[Address(RVA = "0x46F6820", Offset = "0x46F6820", VA = "0x46F6820")]
	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DF6")]
	[Address(RVA = "0x46F6918", Offset = "0x46F6918", VA = "0x46F6918")]
	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DF7")]
	[Address(RVA = "0x46F6A08", Offset = "0x46F6A08", VA = "0x46F6A08")]
	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DF8")]
	[Address(RVA = "0x46F6AF0", Offset = "0x46F6AF0", VA = "0x46F6AF0")]
	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DF9")]
	[Address(RVA = "0x46F6C00", Offset = "0x46F6C00", VA = "0x46F6C00")]
	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DFA")]
	[Address(RVA = "0x46F6CE8", Offset = "0x46F6CE8", VA = "0x46F6CE8")]
	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DFB")]
	[Address(RVA = "0x46F6DE0", Offset = "0x46F6DE0", VA = "0x46F6DE0")]
	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DFC")]
	[Address(RVA = "0x46F6ED0", Offset = "0x46F6ED0", VA = "0x46F6ED0")]
	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DFD")]
	[Address(RVA = "0x46F6FC8", Offset = "0x46F6FC8", VA = "0x46F6FC8")]
	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018DFE")]
	[Address(RVA = "0x46F70B8", Offset = "0x46F70B8", VA = "0x46F70B8")]
	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018DFF")]
	[Address(RVA = "0x46F71A8", Offset = "0x46F71A8", VA = "0x46F71A8")]
	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E00")]
	[Address(RVA = "0x46F7290", Offset = "0x46F7290", VA = "0x46F7290")]
	public static extern int CSharp_Init(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E01")]
	[Address(RVA = "0x46F7390", Offset = "0x46F7390", VA = "0x46F7390")]
	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E02")]
	[Address(RVA = "0x46F74A8", Offset = "0x46F74A8", VA = "0x46F74A8")]
	public static extern int CSharp_InitCommunication(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E03")]
	[Address(RVA = "0x46F75C0", Offset = "0x46F75C0", VA = "0x46F75C0")]
	public static extern void CSharp_Term();

	[PreserveSig]
	[Token(Token = "0x6018E04")]
	[Address(RVA = "0x46F76B0", Offset = "0x46F76B0", VA = "0x46F76B0")]
	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E05")]
	[Address(RVA = "0x46F7798", Offset = "0x46F7798", VA = "0x46F7798")]
	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E06")]
	[Address(RVA = "0x46F7888", Offset = "0x46F7888", VA = "0x46F7888")]
	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6018E07")]
	[Address(RVA = "0x46F79A8", Offset = "0x46F79A8", VA = "0x46F79A8")]
	public static extern int CSharp_SetBasePath(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E08")]
	[Address(RVA = "0x46F7AD8", Offset = "0x46F7AD8", VA = "0x46F7AD8")]
	public static extern int CSharp_SetCurrentLanguage(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E09")]
	[Address(RVA = "0x46F7C18", Offset = "0x46F7C18", VA = "0x46F7C18")]
	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6018E0A")]
	[Address(RVA = "0x46F7D60", Offset = "0x46F7D60", VA = "0x46F7D60")]
	public static extern int CSharp_AddBasePath(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E0B")]
	[Address(RVA = "0x46F7E90", Offset = "0x46F7E90", VA = "0x46F7E90")]
	public static extern int CSharp_SetGameName(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E0C")]
	[Address(RVA = "0x46F7FC0", Offset = "0x46F7FC0", VA = "0x46F7FC0")]
	public static extern int CSharp_SetDecodedBankPath(string jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E0D")]
	[Address(RVA = "0x46F8100", Offset = "0x46F8100", VA = "0x46F8100")]
	public static extern int CSharp_LoadAndDecodeBank(string jarg1, bool jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018E0E")]
	[Address(RVA = "0x46F8250", Offset = "0x46F8250", VA = "0x46F8250")]
	public static extern int CSharp_LoadAndDecodeBankFromMemory(IntPtr jarg1, uint jarg2, bool jarg3, string jarg4, bool jarg5, out uint jarg6);

	[PreserveSig]
	[Token(Token = "0x6018E0F")]
	[Address(RVA = "0x46F8380", Offset = "0x46F8380", VA = "0x46F8380")]
	public static extern IntPtr CSharp_GetCurrentLanguage();

	[PreserveSig]
	[Token(Token = "0x6018E10")]
	[Address(RVA = "0x46F8488", Offset = "0x46F8488", VA = "0x46F8488")]
	public static extern int CSharp_UnloadFilePackage(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E11")]
	[Address(RVA = "0x46F85A0", Offset = "0x46F85A0", VA = "0x46F85A0")]
	public static extern int CSharp_UnloadAllFilePackages();

	[PreserveSig]
	[Token(Token = "0x6018E12")]
	[Address(RVA = "0x46F8678", Offset = "0x46F8678", VA = "0x46F8678")]
	public static extern int CSharp_SetObjectPosition(ulong jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);

	[PreserveSig]
	[Token(Token = "0x6018E13")]
	[Address(RVA = "0x46F87E0", Offset = "0x46F87E0", VA = "0x46F87E0")]
	public static extern int CSharp_GetSourceMultiplePlayPositions(uint jarg1, [Out] uint[] jarg2, [Out] uint[] jarg3, [Out] int[] jarg4, ref uint jarg5, bool jarg6);

	[PreserveSig]
	[Token(Token = "0x6018E14")]
	[Address(RVA = "0x46F8A40", Offset = "0x46F8A40", VA = "0x46F8A40")]
	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6018E15")]
	[Address(RVA = "0x46F8B70", Offset = "0x46F8B70", VA = "0x46F8B70")]
	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6018E16")]
	[Address(RVA = "0x46F8C60", Offset = "0x46F8C60", VA = "0x46F8C60")]
	public static extern int CSharp_AddOutput(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018E17")]
	[Address(RVA = "0x46F8D88", Offset = "0x46F8D88", VA = "0x46F8D88")]
	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E18")]
	[Address(RVA = "0x46F8E68", Offset = "0x46F8E68", VA = "0x46F8E68")]
	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E19")]
	[Address(RVA = "0x46F8F48", Offset = "0x46F8F48", VA = "0x46F8F48")]
	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E1A")]
	[Address(RVA = "0x46F9028", Offset = "0x46F9028", VA = "0x46F9028")]
	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E1B")]
	[Address(RVA = "0x46F9108", Offset = "0x46F9108", VA = "0x46F9108")]
	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E1C")]
	[Address(RVA = "0x46F91F0", Offset = "0x46F91F0", VA = "0x46F91F0")]
	public static extern uint CSharp_GetMajorMinorVersion();

	[PreserveSig]
	[Token(Token = "0x6018E1D")]
	[Address(RVA = "0x46F92C8", Offset = "0x46F92C8", VA = "0x46F92C8")]
	public static extern uint CSharp_GetSubminorBuildVersion();

	[PreserveSig]
	[Token(Token = "0x6018E1E")]
	[Address(RVA = "0x46F93A0", Offset = "0x46F93A0", VA = "0x46F93A0")]
	public static extern int CSharp_QueryIndirectPaths(ulong jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018E1F")]
	[Address(RVA = "0x46F94D8", Offset = "0x46F94D8", VA = "0x46F94D8")]
	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, IntPtr jarg2, IntPtr jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6018E20")]
	[Address(RVA = "0x46F95D8", Offset = "0x46F95D8", VA = "0x46F95D8")]
	public static extern int CSharp_SetRoomPortal(ulong jarg1, IntPtr jarg2, IntPtr jarg3, bool jarg4, ulong jarg5, ulong jarg6);

	[PreserveSig]
	[Token(Token = "0x6018E21")]
	[Address(RVA = "0x46F9728", Offset = "0x46F9728", VA = "0x46F9728")]
	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6018E22")]
	[Address(RVA = "0x46F9868", Offset = "0x46F9868", VA = "0x46F9868")]
	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E23")]
	[Address(RVA = "0x46F9958", Offset = "0x46F9958", VA = "0x46F9958")]
	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E24")]
	[Address(RVA = "0x46F9A48", Offset = "0x46F9A48", VA = "0x46F9A48")]
	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, uint jarg7, ulong jarg8, bool jarg9, bool jarg10);

	[PreserveSig]
	[Token(Token = "0x6018E25")]
	[Address(RVA = "0x46F9BB0", Offset = "0x46F9BB0", VA = "0x46F9BB0")]
	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E26")]
	[Address(RVA = "0x46F9C90", Offset = "0x46F9C90", VA = "0x46F9C90")]
	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E27")]
	[Address(RVA = "0x46F9D70", Offset = "0x46F9D70", VA = "0x46F9D70")]
	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E28")]
	[Address(RVA = "0x46F9E58", Offset = "0x46F9E58", VA = "0x46F9E58")]
	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E29")]
	[Address(RVA = "0x46F9F48", Offset = "0x46F9F48", VA = "0x46F9F48")]
	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E2A")]
	[Address(RVA = "0x46FA030", Offset = "0x46FA030", VA = "0x46FA030")]
	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E2B")]
	[Address(RVA = "0x46FA120", Offset = "0x46FA120", VA = "0x46FA120")]
	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E2C")]
	[Address(RVA = "0x46FA218", Offset = "0x46FA218", VA = "0x46FA218")]
	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6018E2D")]
	[Address(RVA = "0x46FA308", Offset = "0x46FA308", VA = "0x46FA308")]
	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1);
}
