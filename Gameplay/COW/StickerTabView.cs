using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CDE")]
public class StickerTabView : MonoBehaviour
{
	[Token(Token = "0x40111D9")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton m_Button;

	[Token(Token = "0x40111DA")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_NameLabel;

	[Token(Token = "0x40111DB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_UnselectLabel;

	[Token(Token = "0x40111DC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_Icon;

	[Token(Token = "0x40111DD")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003CitemID_003Ek__BackingField;

	[Token(Token = "0x1700134D")]
	public uint itemID
	{
		[Token(Token = "0x6012C6A")]
		[Address(RVA = "0x288EB68", Offset = "0x288EB68", VA = "0x288EB68")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6012C6B")]
		[Address(RVA = "0x288EB70", Offset = "0x288EB70", VA = "0x288EB70")]
		private set
		{
		}
	}

	[Token(Token = "0x6012C69")]
	[Address(RVA = "0x288EB60", Offset = "0x288EB60", VA = "0x288EB60")]
	public StickerTabView()
	{
	}

	[Token(Token = "0x6012C6C")]
	[Address(RVA = "0x288EB78", Offset = "0x288EB78", VA = "0x288EB78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012C6D")]
	[Address(RVA = "0x288EC98", Offset = "0x288EC98", VA = "0x288EC98")]
	public void SetStickerTabInfo(ChatStickerPrice chatSticker)
	{
	}

	[Token(Token = "0x6012C6E")]
	[Address(RVA = "0x288EF90", Offset = "0x288EF90", VA = "0x288EF90")]
	private void _003CAwake_003Em__0()
	{
	}
}
