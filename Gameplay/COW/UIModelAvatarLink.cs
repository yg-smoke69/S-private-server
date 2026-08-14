using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002DA1")]
public class UIModelAvatarLink : UIBaseModel, _Attribute
{
	[Token(Token = "0x401182E")]
	private const uint NOT_SELECTED_ID = 0u;

	[Token(Token = "0x401182F")]
	private const byte STEP1_READY = 1;

	[Token(Token = "0x4011830")]
	private const byte STEP2_READY = 2;

	[Token(Token = "0x4011831")]
	private const byte STEP3_READY = 4;

	[Token(Token = "0x4011832")]
	public const uint PropID_AvatarLinkReady = 1u;

	[Token(Token = "0x4011833")]
	public const uint PropID_LinkedAvatarLinkValueChanged = 2u;

	[Token(Token = "0x4011834")]
	public const uint PropID_ExchangeLinkSuccess = 4u;

	[Token(Token = "0x4011835")]
	public const uint PropID_LinkedProfileChanged = 8u;

	[Token(Token = "0x4011836")]
	public const uint PropID_AvatarLinkClaimFinished = 16u;

	[Token(Token = "0x4011837")]
	[FieldOffset(Offset = "0xC")]
	private byte m_ReadyFlag;

	[Token(Token = "0x4011838")]
	[FieldOffset(Offset = "0x10")]
	private uint m_ExchangeLimitNum;

	[Token(Token = "0x4011839")]
	[FieldOffset(Offset = "0x14")]
	private readonly WaitingResponseHandler m_WaitingResponseHandler;

	[Token(Token = "0x401183A")]
	[FieldOffset(Offset = "0x18")]
	private LinkSettingDesc m_LinkSettingDesc;

	[Token(Token = "0x401183B")]
	[FieldOffset(Offset = "0x1C")]
	private LinkedProfileInfo m_LinkedProfileInfo;

	[Token(Token = "0x401183C")]
	[FieldOffset(Offset = "0x20")]
	private LinkExchangeDesc[] m_LinkExchangeInfoArray;

	[Token(Token = "0x401183D")]
	[FieldOffset(Offset = "0x24")]
	private readonly List<LinkProfile> m_LinkProfileList;

	[Token(Token = "0x401183E")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<uint, LinkProfile> m_LinkProfileDict;

	[Token(Token = "0x1700138A")]
	private byte ReadyFlag
	{
		[Token(Token = "0x6013182")]
		[Address(RVA = "0x30BF7E8", Offset = "0x30BF7E8", VA = "0x30BF7E8")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6013183")]
		[Address(RVA = "0x30BF840", Offset = "0x30BF840", VA = "0x30BF840")]
		set
		{
		}
	}

	[Token(Token = "0x1700138B")]
	private bool IsModelReady
	{
		[Token(Token = "0x6013184")]
		[Address(RVA = "0x30BF9E0", Offset = "0x30BF9E0", VA = "0x30BF9E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700138C")]
	public bool IsAnyLinked
	{
		[Token(Token = "0x6013185")]
		[Address(RVA = "0x30BFA4C", Offset = "0x30BFA4C", VA = "0x30BFA4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700138D")]
	public uint CurrentAvatarID
	{
		[Token(Token = "0x6013186")]
		[Address(RVA = "0x30BFBCC", Offset = "0x30BFBCC", VA = "0x30BFBCC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700138E")]
	public ulong LatestCooldownEndTime
	{
		[Token(Token = "0x6013187")]
		[Address(RVA = "0x30BFC54", Offset = "0x30BFC54", VA = "0x30BFC54")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x6013181")]
	[Address(RVA = "0x30BF6D8", Offset = "0x30BF6D8", VA = "0x30BF6D8")]
	public UIModelAvatarLink()
	{
	}

	[Token(Token = "0x6013188")]
	[Address(RVA = "0x30BFCE4", Offset = "0x30BFCE4", VA = "0x30BFCE4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013189")]
	[Address(RVA = "0x30BFD3C", Offset = "0x30BFD3C", VA = "0x30BFD3C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601318A")]
	[Address(RVA = "0x30BFE6C", Offset = "0x30BFE6C", VA = "0x30BFE6C", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601318B")]
	[Address(RVA = "0x30BFF9C", Offset = "0x30BFF9C", VA = "0x30BFF9C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601318C")]
	[Address(RVA = "0x30C00E4", Offset = "0x30C00E4", VA = "0x30C00E4", Slot = "14")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601318D")]
	[Address(RVA = "0x30C0C44", Offset = "0x30C0C44", VA = "0x30C0C44", Slot = "15")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601318E")]
	[Address(RVA = "0x30C035C", Offset = "0x30C035C", VA = "0x30C035C")]
	private void ShowCommonRewardWndOnLinkUnlocked(proto.AvatarProfile avatarProfile)
	{
	}

	[Token(Token = "0x601318F")]
	[Address(RVA = "0x30BFADC", Offset = "0x30BFADC", VA = "0x30BFADC")]
	private bool ReadyCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6013190")]
	[Address(RVA = "0x30C0CD8", Offset = "0x30C0CD8", VA = "0x30C0CD8")]
	private uint GetSystemLevelLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6013191")]
	[Address(RVA = "0x30C0D70", Offset = "0x30C0D70", VA = "0x30C0D70")]
	private bool GetLinkProfileWithIDInternal(uint avatarID, out LinkProfile linkProfile)
	{
		return default(bool);
	}

	[Token(Token = "0x6013192")]
	[Address(RVA = "0x30C0E7C", Offset = "0x30C0E7C", VA = "0x30C0E7C")]
	private LinkExchangeDesc GetExchangeInfoByIdxInternal(int idx)
	{
		return null;
	}

	[Token(Token = "0x6013193")]
	[Address(RVA = "0x30C0F28", Offset = "0x30C0F28", VA = "0x30C0F28")]
	private uint GetExchangeAmountFromZeroToIdxInternal(int idx)
	{
		return default(uint);
	}

	[Token(Token = "0x6013194")]
	[Address(RVA = "0x30C1028", Offset = "0x30C1028", VA = "0x30C1028")]
	private void SetLinkedProfileInfo(LinkedProfileInfo info)
	{
	}

	[Token(Token = "0x6013195")]
	[Address(RVA = "0x30C110C", Offset = "0x30C110C", VA = "0x30C110C")]
	private bool UpdateGameLinkByID(uint avatarID, AvatarLinkAcquireType type, uint increment)
	{
		return default(bool);
	}

	[Token(Token = "0x6013196")]
	[Address(RVA = "0x30C1748", Offset = "0x30C1748", VA = "0x30C1748")]
	private void OnRequestLinkSettingInfoSuccess()
	{
	}

	[Token(Token = "0x6013197")]
	[Address(RVA = "0x30C19D8", Offset = "0x30C19D8", VA = "0x30C19D8")]
	private void RequestLinkSettingInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013198")]
	[Address(RVA = "0x30C17B0", Offset = "0x30C17B0", VA = "0x30C17B0")]
	private void RequestLinkProfileList()
	{
	}

	[Token(Token = "0x6013199")]
	[Address(RVA = "0x30C09D8", Offset = "0x30C09D8", VA = "0x30C09D8")]
	private void RequestLinkedProfile()
	{
	}

	[Token(Token = "0x601319A")]
	[Address(RVA = "0x30C1C08", Offset = "0x30C1C08", VA = "0x30C1C08")]
	public void RequestUpdateExchangeLink()
	{
	}

	[Token(Token = "0x601319B")]
	[Address(RVA = "0x30C2054", Offset = "0x30C2054", VA = "0x30C2054")]
	public void RequestRelinkProfile(uint avatarID)
	{
	}

	[Token(Token = "0x601319C")]
	[Address(RVA = "0x30C23B8", Offset = "0x30C23B8", VA = "0x30C23B8")]
	public void RequestClaimLinkProfile(uint avatarID)
	{
	}

	[Token(Token = "0x601319D")]
	[Address(RVA = "0x30C269C", Offset = "0x30C269C", VA = "0x30C269C")]
	public void RequestAllMessageOnLogin(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601319E")]
	[Address(RVA = "0x30C26F8", Offset = "0x30C26F8", VA = "0x30C26F8")]
	public bool OnReceiveAwardGameLinkNtf(AwardGameLinkNtf result)
	{
		return default(bool);
	}

	[Token(Token = "0x601319F")]
	[Address(RVA = "0x30C297C", Offset = "0x30C297C", VA = "0x30C297C")]
	public bool RequestALLMessageOnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60131A0")]
	[Address(RVA = "0x30C2AAC", Offset = "0x30C2AAC", VA = "0x30C2AAC")]
	public bool IsLinkDuringCooldown()
	{
		return default(bool);
	}

	[Token(Token = "0x60131A1")]
	[Address(RVA = "0x30C2BBC", Offset = "0x30C2BBC", VA = "0x30C2BBC")]
	public bool IsCurrentSelectedAcquirable()
	{
		return default(bool);
	}

	[Token(Token = "0x60131A2")]
	[Address(RVA = "0x30C2EBC", Offset = "0x30C2EBC", VA = "0x30C2EBC")]
	public bool IsSystemAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60131A3")]
	[Address(RVA = "0x30C2DDC", Offset = "0x30C2DDC", VA = "0x30C2DDC")]
	public bool GetCurrentLinked(out LinkProfile current)
	{
		return default(bool);
	}

	[Token(Token = "0x60131A4")]
	[Address(RVA = "0x30C34B8", Offset = "0x30C34B8", VA = "0x30C34B8")]
	public uint GetCurrentLinkedProgress()
	{
		return default(uint);
	}

	[Token(Token = "0x60131A5")]
	[Address(RVA = "0x30C3544", Offset = "0x30C3544", VA = "0x30C3544")]
	public uint GetCurrentLinkedTarget()
	{
		return default(uint);
	}

	[Token(Token = "0x60131A6")]
	[Address(RVA = "0x30C35FC", Offset = "0x30C35FC", VA = "0x30C35FC")]
	public bool GetLinkProfileWithID(uint linkID, out LinkProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x60131A7")]
	[Address(RVA = "0x30C36D4", Offset = "0x30C36D4", VA = "0x30C36D4")]
	public List<LinkProfile> GetLinkProfileOrderedList()
	{
		return null;
	}

	[Token(Token = "0x60131A8")]
	[Address(RVA = "0x30C2F38", Offset = "0x30C2F38", VA = "0x30C2F38")]
	public LinkSystemStatus GetSystemStatus()
	{
		return default(LinkSystemStatus);
	}

	[Token(Token = "0x60131A9")]
	[Address(RVA = "0x30C3980", Offset = "0x30C3980", VA = "0x30C3980")]
	public uint GetCurrentLinkedDailyGameLink()
	{
		return default(uint);
	}

	[Token(Token = "0x60131AA")]
	[Address(RVA = "0x30C3A08", Offset = "0x30C3A08", VA = "0x30C3A08")]
	public uint GetCurrentLinkedDailyExchangeNum()
	{
		return default(uint);
	}

	[Token(Token = "0x60131AB")]
	[Address(RVA = "0x30C3A90", Offset = "0x30C3A90", VA = "0x30C3A90")]
	public uint GetCurrentLinkedDailyGameMax()
	{
		return default(uint);
	}

	[Token(Token = "0x60131AC")]
	[Address(RVA = "0x30C3B2C", Offset = "0x30C3B2C", VA = "0x30C3B2C")]
	public uint GetCurrentLinkedDailyExchangeNumMax()
	{
		return default(uint);
	}

	[Token(Token = "0x60131AD")]
	[Address(RVA = "0x30C3BC8", Offset = "0x30C3BC8", VA = "0x30C3BC8")]
	public uint GetCurrentLinkedDailyExchangeAmountMax()
	{
		return default(uint);
	}

	[Token(Token = "0x60131AE")]
	[Address(RVA = "0x30C3C6C", Offset = "0x30C3C6C", VA = "0x30C3C6C")]
	public LinkExchangeDesc GetFirstExchangeInfo()
	{
		return null;
	}

	[Token(Token = "0x60131AF")]
	[Address(RVA = "0x30C3D54", Offset = "0x30C3D54", VA = "0x30C3D54")]
	public LinkExchangeDesc GetLastExchangeInfoByAvatarID(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60131B0")]
	[Address(RVA = "0x30C3E3C", Offset = "0x30C3E3C", VA = "0x30C3E3C")]
	public LinkExchangeDesc GetExchangeInfoByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x60131B1")]
	[Address(RVA = "0x30C3EC0", Offset = "0x30C3EC0", VA = "0x30C3EC0")]
	public uint GetExchangeAmountFromZeroToIdx(int idx)
	{
		return default(uint);
	}

	[Token(Token = "0x60131B2")]
	[Address(RVA = "0x30C3F44", Offset = "0x30C3F44", VA = "0x30C3F44")]
	public uint GetRelinkCooldown()
	{
		return default(uint);
	}

	[Token(Token = "0x60131B3")]
	[Address(RVA = "0x30C3FCC", Offset = "0x30C3FCC", VA = "0x30C3FCC")]
	public string GetRelinkCooldownText()
	{
		return null;
	}

	[Token(Token = "0x60131B4")]
	[Address(RVA = "0x30C4308", Offset = "0x30C4308", VA = "0x30C4308")]
	public bool IsShowGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x60131B5")]
	[Address(RVA = "0x30C439C", Offset = "0x30C439C", VA = "0x30C439C")]
	private void _003CRequestLinkSettingInfo_003Em__0(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131B6")]
	[Address(RVA = "0x30C455C", Offset = "0x30C455C", VA = "0x30C455C")]
	private void _003CRequestLinkProfileList_003Em__1(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131B7")]
	[Address(RVA = "0x30C48A8", Offset = "0x30C48A8", VA = "0x30C48A8")]
	private void _003CRequestLinkedProfile_003Em__2(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131B8")]
	[Address(RVA = "0x30C4AC0", Offset = "0x30C4AC0", VA = "0x30C4AC0")]
	private void _003CRequestUpdateExchangeLink_003Em__3(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131B9")]
	[Address(RVA = "0x30C4E48", Offset = "0x30C4E48", VA = "0x30C4E48")]
	private void _003CRequestRelinkProfile_003Em__4(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131BA")]
	[Address(RVA = "0x30C4FF0", Offset = "0x30C4FF0", VA = "0x30C4FF0")]
	private void _003CRequestClaimLinkProfile_003Em__5(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60131BB")]
	[Address(RVA = "0x30C5160", Offset = "0x30C5160", VA = "0x30C5160")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60131BC")]
	[Address(RVA = "0x30C5168", Offset = "0x30C5168", VA = "0x30C5168")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x60131BD")]
	[Address(RVA = "0x30C5170", Offset = "0x30C5170", VA = "0x30C5170")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
