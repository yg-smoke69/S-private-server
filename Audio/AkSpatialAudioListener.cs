using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003E39")]
public class AkSpatialAudioListener : AkSpatialAudioBase
{
	[Token(Token = "0x2003E3A")]
	public class SpatialAudioListenerList
	{
		[Token(Token = "0x401A577")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<AkSpatialAudioListener> listenerList;

		[Token(Token = "0x17001B9C")]
		public List<AkSpatialAudioListener> ListenerList
		{
			[Token(Token = "0x60194C8")]
			[Address(RVA = "0x2EB8358", Offset = "0x2EB8358", VA = "0x2EB8358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60194C7")]
		[Address(RVA = "0x2EB82CC", Offset = "0x2EB82CC", VA = "0x2EB82CC")]
		public SpatialAudioListenerList()
		{
		}

		[Token(Token = "0x60194C9")]
		[Address(RVA = "0x2EB7F84", Offset = "0x2EB7F84", VA = "0x2EB7F84")]
		public bool Add(AkSpatialAudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60194CA")]
		[Address(RVA = "0x2EB8140", Offset = "0x2EB8140", VA = "0x2EB8140")]
		public bool Remove(AkSpatialAudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60194CB")]
		[Address(RVA = "0x2EB8360", Offset = "0x2EB8360", VA = "0x2EB8360")]
		private void Refresh()
		{
		}
	}

	[Token(Token = "0x401A574")]
	[FieldOffset(Offset = "0x0")]
	private static AkSpatialAudioListener s_SpatialAudioListener;

	[Token(Token = "0x401A575")]
	[FieldOffset(Offset = "0x4")]
	private static readonly SpatialAudioListenerList spatialAudioListeners;

	[Token(Token = "0x401A576")]
	[FieldOffset(Offset = "0x10")]
	private AkAudioListener AkAudioListener;

	[Token(Token = "0x17001B9A")]
	public static AkAudioListener TheSpatialAudioListener
	{
		[Token(Token = "0x60194C1")]
		[Address(RVA = "0x2EB7CB4", Offset = "0x2EB7CB4", VA = "0x2EB7CB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9B")]
	public static SpatialAudioListenerList SpatialAudioListeners
	{
		[Token(Token = "0x60194C2")]
		[Address(RVA = "0x2EB7DE4", Offset = "0x2EB7DE4", VA = "0x2EB7DE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60194C0")]
	[Address(RVA = "0x2EB7CB0", Offset = "0x2EB7CB0", VA = "0x2EB7CB0")]
	public AkSpatialAudioListener()
	{
	}

	[Token(Token = "0x60194C3")]
	[Address(RVA = "0x2EB7E70", Offset = "0x2EB7E70", VA = "0x2EB7E70")]
	private void Awake()
	{
	}

	[Token(Token = "0x60194C4")]
	[Address(RVA = "0x2EB7ED8", Offset = "0x2EB7ED8", VA = "0x2EB7ED8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60194C5")]
	[Address(RVA = "0x2EB8094", Offset = "0x2EB8094", VA = "0x2EB8094")]
	private void OnDisable()
	{
	}
}
