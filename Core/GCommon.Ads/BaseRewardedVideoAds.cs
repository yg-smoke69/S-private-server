using System;
using Il2CppDummyDll;

namespace GCommon.Ads;

[Token(Token = "0x2003F14")]
public class BaseRewardedVideoAds
{
	[Token(Token = "0x2003F15")]
	public enum LoadStatus
	{
		[Token(Token = "0x401A9DB")]
		Unloaded,
		[Token(Token = "0x401A9DC")]
		Loading,
		[Token(Token = "0x401A9DD")]
		Loaded
	}

	[Token(Token = "0x2003F16")]
	public enum PlayStatus
	{
		[Token(Token = "0x401A9DF")]
		None,
		[Token(Token = "0x401A9E0")]
		Ready,
		[Token(Token = "0x401A9E1")]
		Opening,
		[Token(Token = "0x401A9E2")]
		Opened,
		[Token(Token = "0x401A9E3")]
		Showing,
		[Token(Token = "0x401A9E4")]
		Closed
	}

	[Token(Token = "0x2003F17")]
	public enum PlayEvent
	{
		[Token(Token = "0x401A9E6")]
		None,
		[Token(Token = "0x401A9E7")]
		Open,
		[Token(Token = "0x401A9E8")]
		Play,
		[Token(Token = "0x401A9E9")]
		Click,
		[Token(Token = "0x401A9EA")]
		Complete,
		[Token(Token = "0x401A9EB")]
		Reward,
		[Token(Token = "0x401A9EC")]
		Close
	}

	[Token(Token = "0x401A9D7")]
	[FieldOffset(Offset = "0x0")]
	private static BaseRewardedVideoAds _I;

	[Token(Token = "0x401A9D8")]
	[FieldOffset(Offset = "0x8")]
	private LoadStatus _003CStatusOfLoad_003Ek__BackingField;

	[Token(Token = "0x401A9D9")]
	[FieldOffset(Offset = "0xC")]
	private PlayStatus _003CStatusOfPlay_003Ek__BackingField;

	[Token(Token = "0x17001C18")]
	public static BaseRewardedVideoAds I
	{
		[Token(Token = "0x6019AFA")]
		[Address(RVA = "0x26B21F4", Offset = "0x26B21F4", VA = "0x26B21F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C19")]
	public LoadStatus StatusOfLoad
	{
		[Token(Token = "0x6019AFD")]
		[Address(RVA = "0x26B261C", Offset = "0x26B261C", VA = "0x26B261C")]
		get
		{
			return default(LoadStatus);
		}
		[Token(Token = "0x6019AFE")]
		[Address(RVA = "0x26B2624", Offset = "0x26B2624", VA = "0x26B2624")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001C1A")]
	public PlayStatus StatusOfPlay
	{
		[Token(Token = "0x6019AFF")]
		[Address(RVA = "0x26B262C", Offset = "0x26B262C", VA = "0x26B262C")]
		get
		{
			return default(PlayStatus);
		}
		[Token(Token = "0x6019B00")]
		[Address(RVA = "0x26B2634", Offset = "0x26B2634", VA = "0x26B2634")]
		protected set
		{
		}
	}

	[Token(Token = "0x6019AF9")]
	[Address(RVA = "0x26B2608", Offset = "0x26B2608", VA = "0x26B2608")]
	protected BaseRewardedVideoAds()
	{
	}

	[Token(Token = "0x6019AFB")]
	[Address(RVA = "0x26B2610", Offset = "0x26B2610", VA = "0x26B2610", Slot = "4")]
	public virtual void Init(bool test_mode)
	{
	}

	[Token(Token = "0x6019AFC")]
	[Address(RVA = "0x26B2614", Offset = "0x26B2614", VA = "0x26B2614", Slot = "5")]
	public virtual bool IsInited()
	{
		return default(bool);
	}

	[Token(Token = "0x6019B01")]
	[Address(RVA = "0x26B263C", Offset = "0x26B263C", VA = "0x26B263C", Slot = "6")]
	public virtual void Load(Action<bool> callback, string ad_unit_id)
	{
	}

	[Token(Token = "0x6019B02")]
	[Address(RVA = "0x26B26C0", Offset = "0x26B26C0", VA = "0x26B26C0", Slot = "7")]
	public virtual bool CanCancelLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x6019B03")]
	[Address(RVA = "0x26B26C8", Offset = "0x26B26C8", VA = "0x26B26C8", Slot = "8")]
	public virtual void CancelLoad()
	{
	}

	[Token(Token = "0x6019B04")]
	[Address(RVA = "0x26B26CC", Offset = "0x26B26CC", VA = "0x26B26CC", Slot = "9")]
	public virtual bool CanCancelPlay()
	{
		return default(bool);
	}

	[Token(Token = "0x6019B05")]
	[Address(RVA = "0x26B26D4", Offset = "0x26B26D4", VA = "0x26B26D4", Slot = "10")]
	public virtual void CancelPlay()
	{
	}

	[Token(Token = "0x6019B06")]
	[Address(RVA = "0x26B26D8", Offset = "0x26B26D8", VA = "0x26B26D8", Slot = "11")]
	public virtual void Play(Action<PlayEvent> callback)
	{
	}
}
