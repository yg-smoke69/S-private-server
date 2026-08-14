using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002671")]
public class UIGachaPreviewManager
{
	[Token(Token = "0x2002672")]
	private sealed class _003CGetClotheIDListByAnim_003Ec__AnonStorey0
	{
		[Token(Token = "0x400ED65")]
		[FieldOffset(Offset = "0x8")]
		internal int animID;

		[Token(Token = "0x600E64C")]
		[Address(RVA = "0x2A2601C", Offset = "0x2A2601C", VA = "0x2A2601C")]
		public _003CGetClotheIDListByAnim_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E64D")]
		[Address(RVA = "0x2A26C54", Offset = "0x2A26C54", VA = "0x2A26C54")]
		internal bool _003C_003Em__0(FullscreenCgDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400ED52")]
	[FieldOffset(Offset = "0x8")]
	private Vector3 TURNTABLEGACHADOUBLEANIMCAMERAROTATION;

	[Token(Token = "0x400ED53")]
	private const uint PREVIEWTYPELIMIT = 2u;

	[Token(Token = "0x400ED54")]
	[FieldOffset(Offset = "0x14")]
	private UIGachaCustomizedPreviewUIData m_UIGachaCustomizedPreviewUIData;

	[Token(Token = "0x400ED55")]
	[FieldOffset(Offset = "0x18")]
	private uint m_CurrentGachaID;

	[Token(Token = "0x400ED56")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_SimpleWeaponId;

	[Token(Token = "0x400ED57")]
	[FieldOffset(Offset = "0x20")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400ED58")]
	[FieldOffset(Offset = "0x24")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400ED59")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_AvatarPos;

	[Token(Token = "0x400ED5A")]
	[FieldOffset(Offset = "0x34")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x400ED5B")]
	[FieldOffset(Offset = "0x38")]
	private UINetworkTexture m_CDNTextureComponent;

	[Token(Token = "0x400ED5C")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 panelLeft;

	[Token(Token = "0x400ED5D")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 panelRight;

	[Token(Token = "0x400ED5E")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 m_WeaponTriggerSize;

	[Token(Token = "0x400ED5F")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_WeaponTriggerPos;

	[Token(Token = "0x400ED60")]
	[FieldOffset(Offset = "0x68")]
	private bool m_ShowingAnimationFlag;

	[Token(Token = "0x400ED61")]
	[FieldOffset(Offset = "0x69")]
	private bool m_CurrentGachaIsFullScreenAnim;

	[Token(Token = "0x400ED62")]
	[FieldOffset(Offset = "0x6C")]
	private UIGachaSceneShowType m_CurrenGachaModelShow;

	[Token(Token = "0x400ED63")]
	[FieldOffset(Offset = "0x70")]
	private List<uint> m_ShowTypeList;

	[Token(Token = "0x400ED64")]
	[FieldOffset(Offset = "0x74")]
	private FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

	[Token(Token = "0x600E61D")]
	[Address(RVA = "0x2A21FD4", Offset = "0x2A21FD4", VA = "0x2A21FD4")]
	public UIGachaPreviewManager()
	{
	}

	[Token(Token = "0x600E61E")]
	[Address(RVA = "0x2A220E4", Offset = "0x2A220E4", VA = "0x2A220E4")]
	public void Init(UINetworkTexture texture, FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600E61F")]
	[Address(RVA = "0x2A22254", Offset = "0x2A22254", VA = "0x2A22254")]
	public void OnPreivewTypeChange(FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600E620")]
	[Address(RVA = "0x2A222B4", Offset = "0x2A222B4", VA = "0x2A222B4")]
	public void SetAvatarPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600E621")]
	[Address(RVA = "0x2A2233C", Offset = "0x2A2233C", VA = "0x2A2233C")]
	public void ClearGachaPreviewManagerCtx()
	{
	}

	[Token(Token = "0x600E622")]
	[Address(RVA = "0x2A22390", Offset = "0x2A22390", VA = "0x2A22390")]
	public void SetPreviewSceneBorder(UIWidget uIWidget)
	{
	}

	[Token(Token = "0x600E623")]
	[Address(RVA = "0x2A22414", Offset = "0x2A22414", VA = "0x2A22414")]
	public void RefreshPreviewSceneCtx(uint gachaID)
	{
	}

	[Token(Token = "0x600E624")]
	[Address(RVA = "0x2A228A8", Offset = "0x2A228A8", VA = "0x2A228A8")]
	public void RefreshPreviewScene(bool needSkipAnimation)
	{
	}

	[Token(Token = "0x600E625")]
	[Address(RVA = "0x2A22D0C", Offset = "0x2A22D0C", VA = "0x2A22D0C")]
	public void SetAnimaionOver()
	{
	}

	[Token(Token = "0x600E626")]
	[Address(RVA = "0x2A22D68", Offset = "0x2A22D68", VA = "0x2A22D68")]
	public bool IsPlayingFullScreenAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600E627")]
	[Address(RVA = "0x2A22B74", Offset = "0x2A22B74", VA = "0x2A22B74")]
	private void SkipModelAnim()
	{
	}

	[Token(Token = "0x600E628")]
	[Address(RVA = "0x2A22DC0", Offset = "0x2A22DC0", VA = "0x2A22DC0")]
	public void SetCurrentSceneShowType(UIGachaSceneShowType showType)
	{
	}

	[Token(Token = "0x600E629")]
	[Address(RVA = "0x2A22FC8", Offset = "0x2A22FC8", VA = "0x2A22FC8")]
	public UIGachaSceneShowType GetCurrentSceneShowType()
	{
		return default(UIGachaSceneShowType);
	}

	[Token(Token = "0x600E62A")]
	[Address(RVA = "0x2A23020", Offset = "0x2A23020", VA = "0x2A23020")]
	public List<uint> GetCurrentOtherShowType()
	{
		return null;
	}

	[Token(Token = "0x600E62B")]
	[Address(RVA = "0x2A23220", Offset = "0x2A23220", VA = "0x2A23220")]
	public void ClosePreviewScene()
	{
	}

	[Token(Token = "0x600E62C")]
	[Address(RVA = "0x2A22940", Offset = "0x2A22940", VA = "0x2A22940")]
	public void RefreshPreviewScenePlayAnimation(bool needSkipAnimation = false)
	{
	}

	[Token(Token = "0x600E62D")]
	[Address(RVA = "0x2A233BC", Offset = "0x2A233BC", VA = "0x2A233BC")]
	private void ShowCDNSceneBg()
	{
	}

	[Token(Token = "0x600E62E")]
	[Address(RVA = "0x2A23570", Offset = "0x2A23570", VA = "0x2A23570")]
	private void ShowAnimationScene(bool needSkipAnimation = false)
	{
	}

	[Token(Token = "0x600E62F")]
	[Address(RVA = "0x2A23EBC", Offset = "0x2A23EBC", VA = "0x2A23EBC")]
	public void ResetPreviewItemPanelSize()
	{
	}

	[Token(Token = "0x600E630")]
	[Address(RVA = "0x2A22C30", Offset = "0x2A22C30", VA = "0x2A22C30")]
	public void SkipAllAnim()
	{
	}

	[Token(Token = "0x600E631")]
	[Address(RVA = "0x2A23F10", Offset = "0x2A23F10", VA = "0x2A23F10")]
	public void SkipPreviewFullScreenAnim()
	{
	}

	[Token(Token = "0x600E632")]
	[Address(RVA = "0x2A23F94", Offset = "0x2A23F94", VA = "0x2A23F94")]
	public void NotifyContentUIShow()
	{
	}

	[Token(Token = "0x600E633")]
	[Address(RVA = "0x2A240A0", Offset = "0x2A240A0", VA = "0x2A240A0")]
	public void NotifyContentUIHide()
	{
	}

	[Token(Token = "0x600E634")]
	[Address(RVA = "0x2A241AC", Offset = "0x2A241AC", VA = "0x2A241AC")]
	public void SetSwitchBtnActive(bool activeState)
	{
	}

	[Token(Token = "0x600E635")]
	[Address(RVA = "0x2A24208", Offset = "0x2A24208", VA = "0x2A24208")]
	public bool HasPreviewAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600E636")]
	[Address(RVA = "0x2A24260", Offset = "0x2A24260", VA = "0x2A24260")]
	public void PlayPreviewAnimation()
	{
	}

	[Token(Token = "0x600E637")]
	[Address(RVA = "0x2A24740", Offset = "0x2A24740", VA = "0x2A24740")]
	public void ClearAvatarOnly()
	{
	}

	[Token(Token = "0x600E638")]
	[Address(RVA = "0x2A247BC", Offset = "0x2A247BC", VA = "0x2A247BC")]
	public void ShowPreviewRewardPoolItem(BaseItemInfo itemInfo)
	{
	}

	[Token(Token = "0x600E639")]
	[Address(RVA = "0x2A23A00", Offset = "0x2A23A00", VA = "0x2A23A00")]
	private FullScreenAnimParams CreateFullScreenAnimParmas()
	{
		return null;
	}

	[Token(Token = "0x600E63A")]
	[Address(RVA = "0x2A24920", Offset = "0x2A24920", VA = "0x2A24920")]
	private void SetAvatarTransformInfo(AvatarTransformInfo avatarInfoA, AvatarTransformInfo avatarInfoB)
	{
	}

	[Token(Token = "0x600E63B")]
	[Address(RVA = "0x2A23BD8", Offset = "0x2A23BD8", VA = "0x2A23BD8")]
	private void RefreshPreivewAvatar(bool needSkipAnimation = false)
	{
	}

	[Token(Token = "0x600E63C")]
	[Address(RVA = "0x2A24CA4", Offset = "0x2A24CA4", VA = "0x2A24CA4")]
	private void ShowComPositePreviewModel(GachaDesc desc)
	{
	}

	[Token(Token = "0x600E63D")]
	[Address(RVA = "0x2A25A3C", Offset = "0x2A25A3C", VA = "0x2A25A3C")]
	private PlayDoubleAvatarAnimParams CreatePlayDoubleAvatarAnimParams(List<uint> idlistA, List<uint> idlistB, int doubleanimA = 1, int doubleanimB = 1, string doublespecialA = "", string doubleidleA = "", string doublespecialB = "", string doubleidleB = "")
	{
		return null;
	}

	[Token(Token = "0x600E63E")]
	[Address(RVA = "0x2A25C98", Offset = "0x2A25C98", VA = "0x2A25C98")]
	private PlayDoubleAvatarAnimParams.AvatarAnimParams CreateAvatarAnimParams(List<uint> idlist, int doubleanim = 1, string doublespecial = "", string doubleidle = "")
	{
		return null;
	}

	[Token(Token = "0x600E63F")]
	[Address(RVA = "0x2A2574C", Offset = "0x2A2574C", VA = "0x2A2574C")]
	private List<uint> Get1PModelList(GachaDesc desc)
	{
		return null;
	}

	[Token(Token = "0x600E640")]
	[Address(RVA = "0x2A25350", Offset = "0x2A25350", VA = "0x2A25350")]
	private void ShowSimplePreviewModel(GachaDesc desc, bool needSkipAnimation = false)
	{
	}

	[Token(Token = "0x600E641")]
	[Address(RVA = "0x2A23CA4", Offset = "0x2A23CA4", VA = "0x2A23CA4")]
	private void TryPlayFullScreenAnim(FullscreenCgDesc data)
	{
	}

	[Token(Token = "0x600E642")]
	[Address(RVA = "0x2A24560", Offset = "0x2A24560", VA = "0x2A24560")]
	private bool IsAllClothesOwned(uint animID)
	{
		return default(bool);
	}

	[Token(Token = "0x600E643")]
	[Address(RVA = "0x2A25DCC", Offset = "0x2A25DCC", VA = "0x2A25DCC")]
	private List<uint> GetClotheIDListByAnim(int animID)
	{
		return null;
	}

	[Token(Token = "0x600E644")]
	[Address(RVA = "0x2A26024", Offset = "0x2A26024", VA = "0x2A26024")]
	private List<uint> ProcessAnimData(FullscreenCgDesc animData)
	{
		return null;
	}

	[Token(Token = "0x600E645")]
	[Address(RVA = "0x2A264EC", Offset = "0x2A264EC", VA = "0x2A264EC")]
	private List<uint> DoProcessAnimData(CSSharedItemData data, List<uint> clothesID)
	{
		return null;
	}

	[Token(Token = "0x600E646")]
	[Address(RVA = "0x2A24B78", Offset = "0x2A24B78", VA = "0x2A24B78")]
	private void PreviewManagerReset()
	{
	}

	[Token(Token = "0x600E647")]
	[Address(RVA = "0x2A26654", Offset = "0x2A26654", VA = "0x2A26654")]
	private bool CheckItemABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600E648")]
	[Address(RVA = "0x2A267A0", Offset = "0x2A267A0", VA = "0x2A267A0")]
	public void TryHidePreviewPanelOnShowAnimation()
	{
	}

	[Token(Token = "0x600E649")]
	[Address(RVA = "0x2A268E4", Offset = "0x2A268E4", VA = "0x2A268E4")]
	public void TryShowPreviewOnAnimationOver(bool needSkip = false)
	{
	}

	[Token(Token = "0x600E64A")]
	[Address(RVA = "0x2A26A9C", Offset = "0x2A26A9C", VA = "0x2A26A9C")]
	public void LogEventTypeFullScreenAnimation(float playTime = 0f, float animTime = 0f, uint isPlayActively = 0u)
	{
	}

	[Token(Token = "0x600E64B")]
	[Address(RVA = "0x2A227A8", Offset = "0x2A227A8", VA = "0x2A227A8")]
	private void SetPreviewShowAvatar()
	{
	}
}
