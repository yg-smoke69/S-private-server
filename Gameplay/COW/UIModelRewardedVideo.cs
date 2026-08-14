using GCommon;
using GCommon.Ads;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003215")]
public class UIModelRewardedVideo : UIBaseModel
{
	[Token(Token = "0x2003216")]
	public class PlayResult
	{
		[Token(Token = "0x40130EB")]
		[FieldOffset(Offset = "0x8")]
		public bool Opened;

		[Token(Token = "0x40130EC")]
		[FieldOffset(Offset = "0x9")]
		public bool Played;

		[Token(Token = "0x40130ED")]
		[FieldOffset(Offset = "0xA")]
		public bool Clicked;

		[Token(Token = "0x40130EE")]
		[FieldOffset(Offset = "0xB")]
		public bool Completed;

		[Token(Token = "0x40130EF")]
		[FieldOffset(Offset = "0xC")]
		public bool Rewarded;

		[Token(Token = "0x601520F")]
		[Address(RVA = "0x2D003C4", Offset = "0x2D003C4", VA = "0x2D003C4")]
		public PlayResult()
		{
		}
	}

	[Token(Token = "0x2003217")]
	public enum LoadStatus
	{
		[Token(Token = "0x40130F1")]
		Unloaded,
		[Token(Token = "0x40130F2")]
		Loading,
		[Token(Token = "0x40130F3")]
		Loaded
	}

	[Token(Token = "0x2003218")]
	public enum PlayStatus
	{
		[Token(Token = "0x40130F5")]
		None,
		[Token(Token = "0x40130F6")]
		Ready,
		[Token(Token = "0x40130F7")]
		Playing,
		[Token(Token = "0x40130F8")]
		Closed
	}

	[Token(Token = "0x40130E4")]
	public const uint PropID_LoadCallback = 2u;

	[Token(Token = "0x40130E5")]
	public const uint PropID_PlayCallback = 4u;

	[Token(Token = "0x40130E6")]
	public const uint PropID_PlaySuccess = 8u;

	[Token(Token = "0x40130E7")]
	private const bool TEST_MODE = true;

	[Token(Token = "0x40130E8")]
	[FieldOffset(Offset = "0xC")]
	private BaseRewardedVideoAds _handler;

	[Token(Token = "0x40130E9")]
	[FieldOffset(Offset = "0x10")]
	private PlayResult _PendingResult;

	[Token(Token = "0x40130EA")]
	[FieldOffset(Offset = "0x14")]
	private float volume;

	[Token(Token = "0x17001641")]
	public bool ShouldPreload
	{
		[Token(Token = "0x60151F9")]
		[Address(RVA = "0x2CFFBF0", Offset = "0x2CFFBF0", VA = "0x2CFFBF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001642")]
	public bool ShowRewardedVideo
	{
		[Token(Token = "0x60151FA")]
		[Address(RVA = "0x2CFFC48", Offset = "0x2CFFC48", VA = "0x2CFFC48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001643")]
	public LoadStatus StatusOfLoad
	{
		[Token(Token = "0x6015205")]
		[Address(RVA = "0x2D0004C", Offset = "0x2D0004C", VA = "0x2D0004C")]
		get
		{
			return default(LoadStatus);
		}
	}

	[Token(Token = "0x17001644")]
	public PlayStatus StatusOfPlay
	{
		[Token(Token = "0x6015206")]
		[Address(RVA = "0x2D000A4", Offset = "0x2D000A4", VA = "0x2D000A4")]
		get
		{
			return default(PlayStatus);
		}
	}

	[Token(Token = "0x60151F7")]
	[Address(RVA = "0x2CFFB14", Offset = "0x2CFFB14", VA = "0x2CFFB14")]
	public UIModelRewardedVideo()
	{
	}

	[Token(Token = "0x60151F8")]
	[Address(RVA = "0x2CFFB98", Offset = "0x2CFFB98", VA = "0x2CFFB98", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60151FB")]
	[Address(RVA = "0x2CFFCA0", Offset = "0x2CFFCA0", VA = "0x2CFFCA0")]
	private bool EnableRewardVideo(ESwitch.SwitchFunc func, bool forceEnable = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60151FC")]
	[Address(RVA = "0x2CFFD1C", Offset = "0x2CFFD1C", VA = "0x2CFFD1C")]
	public bool NeedShowRewardVideoAfterMatch(float curMatchPlayTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60151FD")]
	[Address(RVA = "0x2CFFD80", Offset = "0x2CFFD80", VA = "0x2CFFD80")]
	public void AutoClaimPrevAfterMatchRewardVideoAwards()
	{
	}

	[Token(Token = "0x60151FE")]
	[Address(RVA = "0x2CFFDD4", Offset = "0x2CFFDD4", VA = "0x2CFFDD4")]
	public void ClaimPrevAfterMatchRewardVideoAwardsDirectly()
	{
	}

	[Token(Token = "0x60151FF")]
	[Address(RVA = "0x2CFFE28", Offset = "0x2CFFE28", VA = "0x2CFFE28")]
	public EActivity.State GetAfterMatchRewardVideoActivityStatus()
	{
		return default(EActivity.State);
	}

	[Token(Token = "0x6015200")]
	[Address(RVA = "0x2CFFE98", Offset = "0x2CFFE98", VA = "0x2CFFE98")]
	public ActivityClientInfo GetAfterMatchRewardVideoActivity()
	{
		return null;
	}

	[Token(Token = "0x6015201")]
	[Address(RVA = "0x2CFFEF0", Offset = "0x2CFFEF0", VA = "0x2CFFEF0")]
	public ClientActivityDesc GetAfterMatchRewardVideoActivityDesc()
	{
		return null;
	}

	[Token(Token = "0x6015202")]
	[Address(RVA = "0x2CFFF48", Offset = "0x2CFFF48", VA = "0x2CFFF48")]
	public ActivityGroupDesc GetAfterMatchRewardVideoGroupDesc()
	{
		return null;
	}

	[Token(Token = "0x6015203")]
	[Address(RVA = "0x2CFFFA0", Offset = "0x2CFFFA0", VA = "0x2CFFFA0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6015204")]
	[Address(RVA = "0x2CFFFF4", Offset = "0x2CFFFF4", VA = "0x2CFFFF4")]
	public bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6015207")]
	[Address(RVA = "0x2D000FC", Offset = "0x2D000FC", VA = "0x2D000FC")]
	public bool CanCancelLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x6015208")]
	[Address(RVA = "0x2D00154", Offset = "0x2D00154", VA = "0x2D00154")]
	public void CancelLoad()
	{
	}

	[Token(Token = "0x6015209")]
	[Address(RVA = "0x2D001A8", Offset = "0x2D001A8", VA = "0x2D001A8")]
	public bool CanCancelPlay()
	{
		return default(bool);
	}

	[Token(Token = "0x601520A")]
	[Address(RVA = "0x2D00200", Offset = "0x2D00200", VA = "0x2D00200")]
	public void CancelPlay()
	{
	}

	[Token(Token = "0x601520B")]
	[Address(RVA = "0x2D00254", Offset = "0x2D00254", VA = "0x2D00254")]
	public void Load(EActivity.Event evt)
	{
	}

	[Token(Token = "0x601520C")]
	[Address(RVA = "0x2D002B0", Offset = "0x2D002B0", VA = "0x2D002B0")]
	public void Play(EActivity.Event evt)
	{
	}

	[Token(Token = "0x601520D")]
	[Address(RVA = "0x2D0030C", Offset = "0x2D0030C", VA = "0x2D0030C")]
	private void OnLoadCallback(bool loaded)
	{
	}

	[Token(Token = "0x601520E")]
	[Address(RVA = "0x2D00368", Offset = "0x2D00368", VA = "0x2D00368")]
	private void OnPlayEvent(BaseRewardedVideoAds.PlayEvent pe)
	{
	}
}
