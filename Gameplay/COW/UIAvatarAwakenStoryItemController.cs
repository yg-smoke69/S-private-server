using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001FB1")]
public class UIAvatarAwakenStoryItemController : MonoBehaviour
{
	[Token(Token = "0x400C6BD")]
	[FieldOffset(Offset = "0xC")]
	private AvatarAwakenComicData m_Data;

	[Token(Token = "0x400C6BE")]
	[FieldOffset(Offset = "0x10")]
	public UIButton PlayButton;

	[Token(Token = "0x400C6BF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc;

	[Token(Token = "0x400C6C0")]
	[FieldOffset(Offset = "0x18")]
	private uint m_StoryId;

	[Token(Token = "0x400C6C1")]
	[FieldOffset(Offset = "0x1C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C6C2")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt CDNIMG;

	[Token(Token = "0x400C6C3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LockGroup;

	[Token(Token = "0x400C6C4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LockAll;

	[Token(Token = "0x400C6C5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LockComponent;

	[Token(Token = "0x400C6C6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LockPos1;

	[Token(Token = "0x400C6C7")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LockPos2;

	[Token(Token = "0x400C6C8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LockPos3;

	[Token(Token = "0x400C6C9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LockIcon1;

	[Token(Token = "0x400C6CA")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LockIcon2;

	[Token(Token = "0x400C6CB")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LockIcon3;

	[Token(Token = "0x400C6CC")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LockProgress;

	[Token(Token = "0x400C6CD")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite AwakenItemIcon;

	[Token(Token = "0x400C6CE")]
	[FieldOffset(Offset = "0x50")]
	public UIButton LockBtn1;

	[Token(Token = "0x400C6CF")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LockBtn2;

	[Token(Token = "0x400C6D0")]
	[FieldOffset(Offset = "0x58")]
	public UIButton LockBtn3;

	[Token(Token = "0x400C6D1")]
	[FieldOffset(Offset = "0x5C")]
	public Animator effectAnim;

	[Token(Token = "0x400C6D2")]
	[FieldOffset(Offset = "0x60")]
	public UISprite LockSprite;

	[Token(Token = "0x400C6D3")]
	[FieldOffset(Offset = "0x64")]
	public UIPanel EffectPanel;

	[Token(Token = "0x400C6D4")]
	[FieldOffset(Offset = "0x68")]
	private StoryShowState m_CurrentState;

	[Token(Token = "0x400C6D5")]
	[FieldOffset(Offset = "0x6C")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x6009E51")]
	[Address(RVA = "0x1E83498", Offset = "0x1E83498", VA = "0x1E83498")]
	public UIAvatarAwakenStoryItemController()
	{
	}

	[Token(Token = "0x6009E52")]
	[Address(RVA = "0x1E834A8", Offset = "0x1E834A8", VA = "0x1E834A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6009E53")]
	[Address(RVA = "0x1E7C420", Offset = "0x1E7C420", VA = "0x1E7C420")]
	public StoryShowState GetCurShowState()
	{
		return default(StoryShowState);
	}

	[Token(Token = "0x6009E54")]
	[Address(RVA = "0x1E7C478", Offset = "0x1E7C478", VA = "0x1E7C478")]
	public bool CanCurrentStateUnlock()
	{
		return default(bool);
	}

	[Token(Token = "0x6009E55")]
	[Address(RVA = "0x1E7C1A4", Offset = "0x1E7C1A4", VA = "0x1E7C1A4")]
	public void SetGuideShow(bool show)
	{
	}

	[Token(Token = "0x6009E56")]
	[Address(RVA = "0x1E7BFD4", Offset = "0x1E7BFD4", VA = "0x1E7BFD4")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x6009E57")]
	[Address(RVA = "0x1E837F0", Offset = "0x1E837F0", VA = "0x1E837F0")]
	private StoryShowState GetCurrentShowState(AwakenComic comicInfoBefore, AwakenComic comicInfoCur)
	{
		return default(StoryShowState);
	}

	[Token(Token = "0x6009E58")]
	[Address(RVA = "0x1E7B3BC", Offset = "0x1E7B3BC", VA = "0x1E7B3BC")]
	public void SetCDNInfo(AvatarAwakenComicData comicData)
	{
	}

	[Token(Token = "0x6009E59")]
	[Address(RVA = "0x1E83F24", Offset = "0x1E83F24", VA = "0x1E83F24")]
	private void OnPlayButtonClick()
	{
	}

	[Token(Token = "0x6009E5A")]
	[Address(RVA = "0x1E84314", Offset = "0x1E84314", VA = "0x1E84314")]
	private void OnUnlockButtonClick_1()
	{
	}

	[Token(Token = "0x6009E5B")]
	[Address(RVA = "0x1E84774", Offset = "0x1E84774", VA = "0x1E84774")]
	private void OnUnlockButtonClick_2()
	{
	}

	[Token(Token = "0x6009E5C")]
	[Address(RVA = "0x1E847E0", Offset = "0x1E847E0", VA = "0x1E847E0")]
	private void OnUnlockButtonClick_3()
	{
	}

	[Token(Token = "0x6009E5D")]
	[Address(RVA = "0x1E84380", Offset = "0x1E84380", VA = "0x1E84380")]
	private void OnUnlockButtonClick()
	{
	}

	[Token(Token = "0x6009E5E")]
	[Address(RVA = "0x1E8395C", Offset = "0x1E8395C", VA = "0x1E8395C")]
	private void UpdateAwakenItem()
	{
	}

	[Token(Token = "0x6009E5F")]
	[Address(RVA = "0x1E838F0", Offset = "0x1E838F0", VA = "0x1E838F0")]
	private void UpdateButtonState(StoryShowState state)
	{
	}

	[Token(Token = "0x6009E60")]
	[Address(RVA = "0x1E8484C", Offset = "0x1E8484C", VA = "0x1E8484C")]
	private void SetShowState(StoryShowState state)
	{
	}

	[Token(Token = "0x6009E61")]
	[Address(RVA = "0x1E83E7C", Offset = "0x1E83E7C", VA = "0x1E83E7C")]
	private void SetCDN(UINetworkTextureExt cdn, string url)
	{
	}
}
