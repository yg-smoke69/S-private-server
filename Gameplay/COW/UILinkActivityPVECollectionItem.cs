using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002185")]
public class UILinkActivityPVECollectionItem : MonoBehaviour
{
	[Token(Token = "0x2002186")]
	public delegate void OnItemClick(uint processID);

	[Token(Token = "0x400D234")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_ProgressIcon;

	[Token(Token = "0x400D235")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_ProgressLabel;

	[Token(Token = "0x400D236")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_ProgressIconReadyContainer;

	[Token(Token = "0x400D237")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_GiftContainer;

	[Token(Token = "0x400D238")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject m_GiftNormalContainer;

	[Token(Token = "0x400D239")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_GiftReadyContainer;

	[Token(Token = "0x400D23A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject m_GiftFinishContainer;

	[Token(Token = "0x400D23B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton m_GiftBtn;

	[Token(Token = "0x400D23C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject m_OpenGameContainer;

	[Token(Token = "0x400D23D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton m_OpenBtn;

	[Token(Token = "0x400D23E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject m_OpenReadyContainer;

	[Token(Token = "0x400D23F")]
	[FieldOffset(Offset = "0x38")]
	private uint m_ProcessID;

	[Token(Token = "0x400D240")]
	[FieldOffset(Offset = "0x3C")]
	private ENUM_CollectionState m_CurState;

	[Token(Token = "0x400D241")]
	[FieldOffset(Offset = "0x40")]
	public OnItemClick m_OnItemClick;

	[Token(Token = "0x17001021")]
	private bool m_IsOpenGameItem
	{
		[Token(Token = "0x600B1D1")]
		[Address(RVA = "0x2553E88", Offset = "0x2553E88", VA = "0x2553E88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B1D0")]
	[Address(RVA = "0x2553E80", Offset = "0x2553E80", VA = "0x2553E80")]
	public UILinkActivityPVECollectionItem()
	{
	}

	[Token(Token = "0x600B1D2")]
	[Address(RVA = "0x2553F70", Offset = "0x2553F70", VA = "0x2553F70")]
	public void Init(int collectionIndex, OnItemClick onClick)
	{
	}

	[Token(Token = "0x600B1D3")]
	[Address(RVA = "0x2554210", Offset = "0x2554210", VA = "0x2554210")]
	private void OnGiftBtnClick()
	{
	}

	[Token(Token = "0x600B1D4")]
	[Address(RVA = "0x2554748", Offset = "0x2554748", VA = "0x2554748")]
	private void OnOpenBtnClick()
	{
	}

	[Token(Token = "0x600B1D5")]
	[Address(RVA = "0x2554A5C", Offset = "0x2554A5C", VA = "0x2554A5C")]
	public void UpdateInfo(string count, uint processID, ENUM_CollectionState itemState)
	{
	}

	[Token(Token = "0x600B1D6")]
	[Address(RVA = "0x2554BDC", Offset = "0x2554BDC", VA = "0x2554BDC")]
	private void UpdateGiftInfo()
	{
	}

	[Token(Token = "0x600B1D7")]
	[Address(RVA = "0x2554B30", Offset = "0x2554B30", VA = "0x2554B30")]
	private void UpdateOpenGameInfo()
	{
	}

	[Token(Token = "0x600B1D8")]
	[Address(RVA = "0x2554D34", Offset = "0x2554D34", VA = "0x2554D34")]
	private void UpdateProgressIcon()
	{
	}
}
