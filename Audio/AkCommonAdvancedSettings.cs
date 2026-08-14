using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DCF")]
public class AkCommonAdvancedSettings : AkSettingsValidationHandler
{
	[Serializable]
	[Token(Token = "0x2003DD0")]
	public class SpatialAudioSettings
	{
		[Token(Token = "0x401A41F")]
		[FieldOffset(Offset = "0x8")]
		public float m_DiffractionShadowAttenuationFactor;

		[Token(Token = "0x401A420")]
		[FieldOffset(Offset = "0xC")]
		public float m_DiffractionShadowDegrees;

		[Token(Token = "0x601928C")]
		[Address(RVA = "0x35CFF6C", Offset = "0x35CFF6C", VA = "0x35CFF6C")]
		public SpatialAudioSettings()
		{
		}
	}

	[Token(Token = "0x401A410")]
	[FieldOffset(Offset = "0x8")]
	public uint m_IOMemorySize;

	[Token(Token = "0x401A411")]
	[FieldOffset(Offset = "0xC")]
	public float m_TargetAutoStreamBufferLengthMs;

	[Token(Token = "0x401A412")]
	[FieldOffset(Offset = "0x10")]
	public bool m_UseStreamCache;

	[Token(Token = "0x401A413")]
	[FieldOffset(Offset = "0x14")]
	public uint m_MaximumPinnedBytesInCache;

	[Token(Token = "0x401A414")]
	[FieldOffset(Offset = "0x18")]
	public int m_PrepareEventMemoryPoolID;

	[Token(Token = "0x401A415")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_EnableGameSyncPreparation;

	[Token(Token = "0x401A416")]
	[FieldOffset(Offset = "0x20")]
	public uint m_ContinuousPlaybackLookAhead;

	[Token(Token = "0x401A417")]
	[FieldOffset(Offset = "0x24")]
	public uint m_MonitorPoolSize;

	[Token(Token = "0x401A418")]
	[FieldOffset(Offset = "0x28")]
	public uint m_MonitorQueuePoolSize;

	[Token(Token = "0x401A419")]
	[FieldOffset(Offset = "0x2C")]
	public uint m_MaximumHardwareTimeoutMs;

	[Token(Token = "0x401A41A")]
	[FieldOffset(Offset = "0x30")]
	public bool m_DebugOutOfRangeCheckEnabled;

	[Token(Token = "0x401A41B")]
	[FieldOffset(Offset = "0x34")]
	public float m_DebugOutOfRangeLimit;

	[Token(Token = "0x401A41C")]
	[FieldOffset(Offset = "0x38")]
	public SpatialAudioSettings m_SpatialAudioSettings;

	[Token(Token = "0x401A41D")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_RenderDuringFocusLoss;

	[Token(Token = "0x401A41E")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_UseAsyncOpen;

	[Token(Token = "0x6019285")]
	[Address(RVA = "0x35C0DF0", Offset = "0x35C0DF0", VA = "0x35C0DF0")]
	public AkCommonAdvancedSettings()
	{
	}

	[Token(Token = "0x6019286")]
	[Address(RVA = "0x35CF8E8", Offset = "0x35CF8E8", VA = "0x35CF8E8", Slot = "5")]
	public virtual void CopyTo(AkDeviceSettings settings)
	{
	}

	[Token(Token = "0x6019287")]
	[Address(RVA = "0x35CFBEC", Offset = "0x35CFBEC", VA = "0x35CFBEC", Slot = "6")]
	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	[Token(Token = "0x6019288")]
	[Address(RVA = "0x35CFD80", Offset = "0x35CFD80", VA = "0x35CFD80", Slot = "7")]
	public virtual void CopyTo(AkPlatformInitSettings settings)
	{
	}

	[Token(Token = "0x6019289")]
	[Address(RVA = "0x35CFD84", Offset = "0x35CFD84", VA = "0x35CFD84", Slot = "8")]
	public virtual void CopyTo(AkSpatialAudioInitSettings settings)
	{
	}

	[Token(Token = "0x601928A")]
	[Address(RVA = "0x35CFE10", Offset = "0x35CFE10", VA = "0x35CFE10", Slot = "9")]
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
	{
	}

	[Token(Token = "0x601928B")]
	[Address(RVA = "0x35CFE14", Offset = "0x35CFE14", VA = "0x35CFE14", Slot = "4")]
	public override void Validate()
	{
	}
}
