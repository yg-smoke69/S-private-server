using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003515")]
public class UIEmoteShowItemView : MonoBehaviour
{
	[Token(Token = "0x4014F1D")]
	[FieldOffset(Offset = "0xC")]
	public UIButton EmoteItemBtn;

	[Token(Token = "0x4014F1E")]
	[FieldOffset(Offset = "0x10")]
	public UISprite EmoteItemSpr;

	[Token(Token = "0x4014F1F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite booyahEmotionSpr;

	[Token(Token = "0x4014F20")]
	[FieldOffset(Offset = "0x18")]
	public Transform EmotionPos;

	[Token(Token = "0x4014F21")]
	[FieldOffset(Offset = "0x1C")]
	public UINewDownloadInfoController Downloader;

	[Token(Token = "0x4014F22")]
	[FieldOffset(Offset = "0x20")]
	public Transform DesgarTransform;

	[Token(Token = "0x4014F23")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DesgarMask;

	[Token(Token = "0x4014F24")]
	[FieldOffset(Offset = "0x28")]
	private uint m_EmoteID;

	[Token(Token = "0x4014F25")]
	[FieldOffset(Offset = "0x2C")]
	private int m_EmoteSlotId;

	[Token(Token = "0x60162EF")]
	[Address(RVA = "0x19D2CF0", Offset = "0x19D2CF0", VA = "0x19D2CF0")]
	public UIEmoteShowItemView()
	{
	}

	[Token(Token = "0x60162F0")]
	[Address(RVA = "0x19D2CF8", Offset = "0x19D2CF8", VA = "0x19D2CF8")]
	public void SetData(uint eid, int slotId)
	{
	}

	[Token(Token = "0x60162F1")]
	[Address(RVA = "0x19D306C", Offset = "0x19D306C", VA = "0x19D306C")]
	private void OnEmoteItemClick()
	{
	}
}
