using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DCC")]
public class AkCommonUserSettings : AkSettingsValidationHandler
{
	[Serializable]
	[Token(Token = "0x2003DCD")]
	public class SpatialAudioSettings
	{
		[Token(Token = "0x2003DCE")]
		public enum DiffractionFlags
		{
			[Token(Token = "0x401A40D")]
			UseBuiltInParam = 1,
			[Token(Token = "0x401A40E")]
			UseObstruction = 2,
			[Token(Token = "0x401A40F")]
			CalcEmitterVirtualPosition = 8
		}

		[Token(Token = "0x401A408")]
		[FieldOffset(Offset = "0x8")]
		public uint m_PoolSize;

		[Token(Token = "0x401A409")]
		[FieldOffset(Offset = "0xC")]
		public uint m_MaxSoundPropagationDepth;

		[Token(Token = "0x401A40A")]
		[FieldOffset(Offset = "0x10")]
		public DiffractionFlags m_DiffractionFlags;

		[Token(Token = "0x401A40B")]
		[FieldOffset(Offset = "0x14")]
		public float m_MovementThreshold;

		[Token(Token = "0x6019284")]
		[Address(RVA = "0x35D129C", Offset = "0x35D129C", VA = "0x35D129C")]
		public SpatialAudioSettings()
		{
		}
	}

	[Token(Token = "0x401A3F5")]
	[FieldOffset(Offset = "0x8")]
	public string m_BasePath;

	[Token(Token = "0x401A3F6")]
	[FieldOffset(Offset = "0xC")]
	public string m_StartupLanguage;

	[Token(Token = "0x401A3F7")]
	[FieldOffset(Offset = "0x10")]
	public uint m_PreparePoolSize;

	[Token(Token = "0x401A3F8")]
	[FieldOffset(Offset = "0x14")]
	public int m_CallbackManagerBufferSize;

	[Token(Token = "0x401A3F9")]
	[FieldOffset(Offset = "0x18")]
	public bool m_EngineLogging;

	[Token(Token = "0x401A3FA")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_MaximumNumberOfMemoryPools;

	[Token(Token = "0x401A3FB")]
	[FieldOffset(Offset = "0x20")]
	public uint m_MaximumNumberOfPositioningPaths;

	[Token(Token = "0x401A3FC")]
	[FieldOffset(Offset = "0x24")]
	public uint m_DefaultPoolSize;

	[Token(Token = "0x401A3FD")]
	[FieldOffset(Offset = "0x28")]
	public float m_MemoryCutoffThreshold;

	[Token(Token = "0x401A3FE")]
	[FieldOffset(Offset = "0x2C")]
	public uint m_CommandQueueSize;

	[Token(Token = "0x401A3FF")]
	[FieldOffset(Offset = "0x30")]
	public uint m_SamplesPerFrame;

	[Token(Token = "0x401A400")]
	[FieldOffset(Offset = "0x34")]
	public AkCommonOutputSettings m_MainOutputSettings;

	[Token(Token = "0x401A401")]
	[FieldOffset(Offset = "0x38")]
	public float m_StreamingLookAheadRatio;

	[Token(Token = "0x401A402")]
	[FieldOffset(Offset = "0x3C")]
	public uint m_StreamManagerPoolSize;

	[Token(Token = "0x401A403")]
	[FieldOffset(Offset = "0x40")]
	public uint m_SampleRate;

	[Token(Token = "0x401A404")]
	[FieldOffset(Offset = "0x44")]
	public uint m_LowerEnginePoolSize;

	[Token(Token = "0x401A405")]
	[FieldOffset(Offset = "0x48")]
	public float m_LowerEngineMemoryCutoffThreshold;

	[Token(Token = "0x401A406")]
	[FieldOffset(Offset = "0x4C")]
	public ushort m_NumberOfRefillsInVoice;

	[Token(Token = "0x401A407")]
	[FieldOffset(Offset = "0x50")]
	public SpatialAudioSettings m_SpatialAudioSettings;

	[Token(Token = "0x6019279")]
	[Address(RVA = "0x35C0B58", Offset = "0x35C0B58", VA = "0x35C0B58")]
	public AkCommonUserSettings()
	{
	}

	[Token(Token = "0x601927A")]
	[Address(RVA = "0x35D0AF8", Offset = "0x35D0AF8", VA = "0x35D0AF8")]
	public void CopyTo(AkMemSettings settings)
	{
	}

	[Token(Token = "0x601927B")]
	[Address(RVA = "0x35D0E30", Offset = "0x35D0E30", VA = "0x35D0E30")]
	protected static string GetPluginPath()
	{
		return null;
	}

	[Token(Token = "0x601927C")]
	[Address(RVA = "0x35D0E38", Offset = "0x35D0E38", VA = "0x35D0E38", Slot = "5")]
	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	[Token(Token = "0x601927D")]
	[Address(RVA = "0x35D0B60", Offset = "0x35D0B60", VA = "0x35D0B60")]
	public void CopyTo(AkMusicSettings settings)
	{
	}

	[Token(Token = "0x601927E")]
	[Address(RVA = "0x35D0B2C", Offset = "0x35D0B2C", VA = "0x35D0B2C")]
	public void CopyTo(AkStreamMgrSettings settings)
	{
	}

	[Token(Token = "0x601927F")]
	[Address(RVA = "0x35D10B8", Offset = "0x35D10B8", VA = "0x35D10B8", Slot = "6")]
	public virtual void CopyTo(AkDeviceSettings settings)
	{
	}

	[Token(Token = "0x6019280")]
	[Address(RVA = "0x35D10BC", Offset = "0x35D10BC", VA = "0x35D10BC", Slot = "7")]
	public virtual void CopyTo(AkPlatformInitSettings settings)
	{
	}

	[Token(Token = "0x6019281")]
	[Address(RVA = "0x35D1180", Offset = "0x35D1180", VA = "0x35D1180", Slot = "8")]
	public virtual void CopyTo(AkSpatialAudioInitSettings settings)
	{
	}

	[Token(Token = "0x6019282")]
	[Address(RVA = "0x35D127C", Offset = "0x35D127C", VA = "0x35D127C", Slot = "9")]
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
	{
	}

	[Token(Token = "0x6019283")]
	[Address(RVA = "0x35D1280", Offset = "0x35D1280", VA = "0x35D1280", Slot = "4")]
	public override void Validate()
	{
	}
}
