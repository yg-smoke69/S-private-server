using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030A6")]
public class UIModelHyperBook : UIBaseModel
{
	[Token(Token = "0x20030A7")]
	public enum HyperBookState
	{
		[Token(Token = "0x4012816")]
		Unknown,
		[Token(Token = "0x4012817")]
		NotFound,
		[Token(Token = "0x4012818")]
		BeforePre,
		[Token(Token = "0x4012819")]
		Pre,
		[Token(Token = "0x401281A")]
		Open,
		[Token(Token = "0x401281B")]
		Closed
	}

	[Token(Token = "0x20030A8")]
	public enum HyperBookPageState
	{
		[Token(Token = "0x401281D")]
		Unknown,
		[Token(Token = "0x401281E")]
		OutOfDate,
		[Token(Token = "0x401281F")]
		BookNotOwned,
		[Token(Token = "0x4012820")]
		AwardClaimed,
		[Token(Token = "0x4012821")]
		FirstLockedAvailable,
		[Token(Token = "0x4012822")]
		FirstLockedNotAvailable,
		[Token(Token = "0x4012823")]
		WaitForPrevious,
		[Token(Token = "0x4012824")]
		DrawAvailable,
		[Token(Token = "0x4012825")]
		DrawNotAvailable
	}

	[Token(Token = "0x40127FE")]
	private const byte STEP1_READY = 1;

	[Token(Token = "0x40127FF")]
	private const byte STEP2_READY = 2;

	[Token(Token = "0x4012800")]
	private const byte ALL_STEP_READY = 3;

	[Token(Token = "0x4012801")]
	[FieldOffset(Offset = "0xC")]
	private byte m_ReadyFlag;

	[Token(Token = "0x4012802")]
	public const uint PropID_HyperBookReady = 1u;

	[Token(Token = "0x4012803")]
	public const uint PropID_HyperBookSpinNumChanged = 2u;

	[Token(Token = "0x4012804")]
	public const uint PropID_HyperBookPageUnlocked = 4u;

	[Token(Token = "0x4012805")]
	public const uint PropID_SpinHiddenPageFinished = 16u;

	[Token(Token = "0x4012806")]
	public const uint PropID_HyperBookInfoRefresh = 32u;

	[Token(Token = "0x4012807")]
	public const string PlayerPresKey_HyperBook_UnlockAvailable_TipsShow = "HyperBook_UnlockAvailable_TipsShow_{0}_{1}_{2}";

	[Token(Token = "0x4012808")]
	public const string PlayerPresKey_HyperBook_UnlockAvailable_Click = "HyperBook_UnlockAvailable_Click_{0}_{1}_{2}";

	[Token(Token = "0x4012809")]
	public const string PlayerPresKey_HyperBook_DrawAvailable_TipsShow = "HyperBook_DrawAvailable_TipsShow_{0}_{1}";

	[Token(Token = "0x401280A")]
	public const string PlayerPresKey_HyperBook_DrawAvailable_LastDrawNum = "HyperBook_DrawAvailable_LastDrawNum_{0}_{1}";

	[Token(Token = "0x401280B")]
	public const string BookID_PageID_Format = "{0}_{1}";

	[Token(Token = "0x401280C")]
	public const string PLAYERPREF_CLAIM_GUIDE = "PlayerPref_HyperBook_Content_Claim_Guide_{0}";

	[Token(Token = "0x401280D")]
	public const string PLAYERPREF_SECOND_PAGE_GUIDE = "PlayerPref_HyperBook_Content_SecondPage_Guide_{0}";

	[Token(Token = "0x401280E")]
	public const string PLAYERPREF_HIDDEN_PAGE_GUIDE = "PlayerPref_HyperBook_Content_HiddenPage_Guide_{0}";

	[Token(Token = "0x401280F")]
	public const string PLAYERPREF_BOOK_ENTRANCE_GUIDE = "PlayerPref_HyperBook_Entrance_Guide_{0}_{1}";

	[Token(Token = "0x4012810")]
	[FieldOffset(Offset = "0x10")]
	private readonly WaitingResponseHandler m_WaitingResponseHandler;

	[Token(Token = "0x4012811")]
	[FieldOffset(Offset = "0x14")]
	private readonly Dictionary<uint, CollectionBookDesc> m_HyperBookDescDict;

	[Token(Token = "0x4012812")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<uint, HyperBookInfo> m_HyperBookInfoDict;

	[Token(Token = "0x4012813")]
	[FieldOffset(Offset = "0x1C")]
	private readonly Dictionary<string, bool> m_BookIDToPageIDRedTipsCachedDict;

	[Token(Token = "0x4012814")]
	[FieldOffset(Offset = "0x0")]
	private static Func<HyperBookPage, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001527")]
	private byte ReadyFlag
	{
		[Token(Token = "0x601459C")]
		[Address(RVA = "0x12B5BB8", Offset = "0x12B5BB8", VA = "0x12B5BB8")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x601459D")]
		[Address(RVA = "0x12B5C10", Offset = "0x12B5C10", VA = "0x12B5C10")]
		set
		{
		}
	}

	[Token(Token = "0x17001528")]
	private bool IsReady
	{
		[Token(Token = "0x601459E")]
		[Address(RVA = "0x12B5DB0", Offset = "0x12B5DB0", VA = "0x12B5DB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601459B")]
	[Address(RVA = "0x12B5A74", Offset = "0x12B5A74", VA = "0x12B5A74")]
	public UIModelHyperBook()
	{
	}

	[Token(Token = "0x601459F")]
	[Address(RVA = "0x12B5E1C", Offset = "0x12B5E1C", VA = "0x12B5E1C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60145A0")]
	[Address(RVA = "0x12B5E74", Offset = "0x12B5E74", VA = "0x12B5E74", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60145A1")]
	[Address(RVA = "0x12B5FD0", Offset = "0x12B5FD0", VA = "0x12B5FD0")]
	private void RequestHyperBookSetting(bool silence, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60145A2")]
	[Address(RVA = "0x12B6294", Offset = "0x12B6294", VA = "0x12B6294")]
	private void OnRequestHyperBookSettingFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60145A3")]
	[Address(RVA = "0x12B6A94", Offset = "0x12B6A94", VA = "0x12B6A94")]
	private void RequestHyperBookInfo(bool silence, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60145A4")]
	[Address(RVA = "0x12B6D58", Offset = "0x12B6D58", VA = "0x12B6D58")]
	private void OnRequestHyperBookInfoFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60145A5")]
	[Address(RVA = "0x12B7BCC", Offset = "0x12B7BCC", VA = "0x12B7BCC")]
	public void RequestUnlockHyperBookPage(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x60145A6")]
	[Address(RVA = "0x12B8144", Offset = "0x12B8144", VA = "0x12B8144")]
	private void OnRequestUnlockHyperBookPageFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60145A7")]
	[Address(RVA = "0x12B93FC", Offset = "0x12B93FC", VA = "0x12B93FC")]
	public void RequestSpinHyperBookHiddenPage(uint bookID)
	{
	}

	[Token(Token = "0x60145A8")]
	[Address(RVA = "0x12B9688", Offset = "0x12B9688", VA = "0x12B9688")]
	private void OnRequestSpinHyperBookHiddenPageFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x60145A9")]
	[Address(RVA = "0x12BA204", Offset = "0x12BA204", VA = "0x12BA204")]
	public bool ResendRequestIfPreviousFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x60145AA")]
	[Address(RVA = "0x12BA448", Offset = "0x12BA448", VA = "0x12BA448")]
	public void OnInventoryNewItemsNtf(InventoryChangeMessage message)
	{
	}

	[Token(Token = "0x60145AB")]
	[Address(RVA = "0x12B9CF0", Offset = "0x12B9CF0", VA = "0x12B9CF0")]
	private static void LogSpinHyperBookHiddenPageResult(uint bookID, int pageIdx, CSSpinHyperBookHiddenPageRes res)
	{
	}

	[Token(Token = "0x60145AC")]
	[Address(RVA = "0x12BA700", Offset = "0x12BA700", VA = "0x12BA700")]
	private HyperBookState GetHyperBookStateInternal(uint bookID)
	{
		return default(HyperBookState);
	}

	[Token(Token = "0x60145AD")]
	[Address(RVA = "0x12B7EA0", Offset = "0x12B7EA0", VA = "0x12B7EA0")]
	private bool GetHyperBookPageDescInternal(uint bookID, int pageIdx, out CollectionBookItemDesc itemDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60145AE")]
	[Address(RVA = "0x12B85D4", Offset = "0x12B85D4", VA = "0x12B85D4")]
	private bool GetHyperBookPageInfoInternal(uint bookID, int pageIdx, out HyperBookPage pageInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60145AF")]
	[Address(RVA = "0x12BA8F4", Offset = "0x12BA8F4", VA = "0x12BA8F4")]
	private int GetFirstLockedPageIdxInternal(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145B0")]
	[Address(RVA = "0x12BAB7C", Offset = "0x12BAB7C", VA = "0x12BAB7C")]
	private int GetHyperBookPageTokenNumInternal(uint bookID, int pageIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60145B1")]
	[Address(RVA = "0x12B72E4", Offset = "0x12B72E4", VA = "0x12B72E4")]
	private int GetHyperBookRemainSpinNumInternal(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145B2")]
	[Address(RVA = "0x12BAF88", Offset = "0x12BAF88", VA = "0x12BAF88")]
	private bool IsHyperBookVisibleInternal(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B3")]
	[Address(RVA = "0x12BB008", Offset = "0x12BB008", VA = "0x12BB008")]
	private bool IsHyperBookContentAvailableInternal(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B4")]
	[Address(RVA = "0x12BAAB0", Offset = "0x12BAAB0", VA = "0x12BAAB0")]
	private bool IsHyperBookOwnedInternal(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B5")]
	[Address(RVA = "0x12BB088", Offset = "0x12BB088", VA = "0x12BB088")]
	public bool IsSystemAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60145B6")]
	[Address(RVA = "0x12BB0E8", Offset = "0x12BB0E8", VA = "0x12BB0E8")]
	public bool IsHyperBookVisible(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B7")]
	[Address(RVA = "0x12BB16C", Offset = "0x12BB16C", VA = "0x12BB16C")]
	public bool IsHyperBookContentAvailable(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B8")]
	[Address(RVA = "0x12BB1F0", Offset = "0x12BB1F0", VA = "0x12BB1F0")]
	public bool IsHyperBookOwned(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145B9")]
	[Address(RVA = "0x12BB274", Offset = "0x12BB274", VA = "0x12BB274")]
	public bool IsHyperBookHiddenPage(uint bookID, int pageIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x60145BA")]
	[Address(RVA = "0x12BB344", Offset = "0x12BB344", VA = "0x12BB344")]
	public bool IsHyperBookPageUnlocked(uint bookID, int pageIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x60145BB")]
	[Address(RVA = "0x12BB414", Offset = "0x12BB414", VA = "0x12BB414")]
	public void RequestAllMessageOnLogin(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60145BC")]
	[Address(RVA = "0x12BB494", Offset = "0x12BB494", VA = "0x12BB494")]
	public HyperBookState GetHyperBookState(uint bookID)
	{
		return default(HyperBookState);
	}

	[Token(Token = "0x60145BD")]
	[Address(RVA = "0x12BB518", Offset = "0x12BB518", VA = "0x12BB518")]
	public bool GetHyperBookType(uint bookID, out EStore.HyperBookType bookType)
	{
		return default(bool);
	}

	[Token(Token = "0x60145BE")]
	[Address(RVA = "0x12BB648", Offset = "0x12BB648", VA = "0x12BB648")]
	public int GetHyperBookPageCount(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145BF")]
	[Address(RVA = "0x12BB818", Offset = "0x12BB818", VA = "0x12BB818")]
	public int GetHyperBookUnlockCount(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145C0")]
	[Address(RVA = "0x12BB9D4", Offset = "0x12BB9D4", VA = "0x12BB9D4")]
	public int GetFirstLockedPageIdx(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145C1")]
	[Address(RVA = "0x12BBA58", Offset = "0x12BBA58", VA = "0x12BBA58")]
	public int GetHyperBookRemainSpinNum(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145C2")]
	[Address(RVA = "0x12BBADC", Offset = "0x12BBADC", VA = "0x12BBADC")]
	public int GetHyperBookHiddenPageIdx(uint bookID)
	{
		return default(int);
	}

	[Token(Token = "0x60145C3")]
	[Address(RVA = "0x12BBC04", Offset = "0x12BBC04", VA = "0x12BBC04")]
	public HyperBookPageState GetHyperBookPageState(uint bookID, int pageIdx)
	{
		return default(HyperBookPageState);
	}

	[Token(Token = "0x60145C4")]
	[Address(RVA = "0x12BBE30", Offset = "0x12BBE30", VA = "0x12BBE30")]
	public bool GetHyperBookPageDesc(uint bookID, int pageIdx, out CollectionBookItemDesc itemDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60145C5")]
	[Address(RVA = "0x12BBF0C", Offset = "0x12BBF0C", VA = "0x12BBF0C")]
	public bool GetHyperBookPageInfo(uint bookID, int pageIdx, out HyperBookPage pageInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60145C6")]
	[Address(RVA = "0x12BBFE8", Offset = "0x12BBFE8", VA = "0x12BBFE8")]
	public int GetHyperBookPageTokenNum(uint bookID, int pageIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60145C7")]
	[Address(RVA = "0x12BC08C", Offset = "0x12BC08C", VA = "0x12BC08C")]
	public int GetHyperBookPageTokenTarget(uint bookID, int pageIdx)
	{
		return default(int);
	}

	[Token(Token = "0x60145C8")]
	[Address(RVA = "0x12BC154", Offset = "0x12BC154", VA = "0x12BC154")]
	public bool GetHyperBookPageItemBelongsTo(uint itemID, out uint bookID, out int pageIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x60145C9")]
	[Address(RVA = "0x12BC490", Offset = "0x12BC490", VA = "0x12BC490")]
	public uint[] GetVisibleHyperBookIDArray()
	{
		return null;
	}

	[Token(Token = "0x60145CA")]
	[Address(RVA = "0x12BC798", Offset = "0x12BC798", VA = "0x12BC798")]
	public uint[] GetVisibleSortedHyperBookIDArray()
	{
		return null;
	}

	[Token(Token = "0x60145CB")]
	[Address(RVA = "0x12BCB28", Offset = "0x12BCB28", VA = "0x12BCB28")]
	public bool GetHyperBookAwardList(uint bookID, out List<AwardDesc> awardDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60145CC")]
	[Address(RVA = "0x12BCDE0", Offset = "0x12BCDE0", VA = "0x12BCDE0")]
	public bool GetHyperBookPageAward(uint bookID, int pageIdx, out AwardDesc awardDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60145CD")]
	[Address(RVA = "0x12BCED4", Offset = "0x12BCED4", VA = "0x12BCED4")]
	public bool GetHyperBookOpenEndTimeByID(uint bookID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145CE")]
	[Address(RVA = "0x12BD054", Offset = "0x12BD054", VA = "0x12BD054")]
	public bool GetHyperBookPageInfoList(uint bookID, out List<HyperBookPage> pages)
	{
		return default(bool);
	}

	[Token(Token = "0x60145CF")]
	[Address(RVA = "0x12BD2F4", Offset = "0x12BD2F4", VA = "0x12BD2F4")]
	public bool GetHyperBookHiddenPageSpinProbability(uint bookID, int pageID, out string probability)
	{
		return default(bool);
	}

	[Token(Token = "0x60145D0")]
	[Address(RVA = "0x12BD4A8", Offset = "0x12BD4A8", VA = "0x12BD4A8")]
	public bool GetHyperBookUnlockGopos(uint bookID, out uint goPos, out string subGoPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60145D1")]
	[Address(RVA = "0x12BD674", Offset = "0x12BD674", VA = "0x12BD674")]
	public bool GetHyperBookObtainGoPos(uint bookID, out uint goPos, out string subGoPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60145D2")]
	[Address(RVA = "0x12B8E98", Offset = "0x12B8E98", VA = "0x12B8E98")]
	private void UpdateBookUnlockAvailableRedTipsInternal(uint bookID)
	{
	}

	[Token(Token = "0x60145D3")]
	[Address(RVA = "0x12BD840", Offset = "0x12BD840", VA = "0x12BD840")]
	public void UpdateUnlockAvailableRedTips()
	{
	}

	[Token(Token = "0x60145D4")]
	[Address(RVA = "0x12B883C", Offset = "0x12B883C", VA = "0x12B883C")]
	private void UpdateUnlockRedtipsAfterUnlockSucess(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x60145D5")]
	[Address(RVA = "0x12B7644", Offset = "0x12B7644", VA = "0x12B7644")]
	private void UpdateDrawRedTips(uint bookID, int remainNum, bool hiddenPageUnlocked = false)
	{
	}

	[Token(Token = "0x60145D6")]
	[Address(RVA = "0x12B8D34", Offset = "0x12B8D34", VA = "0x12B8D34")]
	private void UpdateDrawRedTipsAfterUnlock(uint bookID, int remainNum)
	{
	}

	[Token(Token = "0x60145D7")]
	[Address(RVA = "0x12BDA98", Offset = "0x12BDA98", VA = "0x12BDA98")]
	private static bool _003CGetHyperBookUnlockCount_003Em__0(HyperBookPage page)
	{
		return default(bool);
	}

	[Token(Token = "0x60145D8")]
	[Address(RVA = "0x12BDABC", Offset = "0x12BDABC", VA = "0x12BDABC")]
	private int _003CGetVisibleSortedHyperBookIDArray_003Em__1(uint bookA, uint bookB)
	{
		return default(int);
	}

	[Token(Token = "0x60145D9")]
	[Address(RVA = "0x12BDBAC", Offset = "0x12BDBAC", VA = "0x12BDBAC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
