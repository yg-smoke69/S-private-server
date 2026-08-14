using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CDD")]
public class StickerSpriteView : MonoBehaviour
{
	[Token(Token = "0x40111D6")]
	[FieldOffset(Offset = "0xC")]
	public UIButton m_Button;

	[Token(Token = "0x40111D7")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_StickerSprite;

	[Token(Token = "0x40111D8")]
	[FieldOffset(Offset = "0x14")]
	private ChatStickerData _003Cm_Data_003Ek__BackingField;

	[Token(Token = "0x1700134C")]
	public ChatStickerData m_Data
	{
		[Token(Token = "0x6012C64")]
		[Address(RVA = "0x288E7FC", Offset = "0x288E7FC", VA = "0x288E7FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012C65")]
		[Address(RVA = "0x288E804", Offset = "0x288E804", VA = "0x288E804")]
		private set
		{
		}
	}

	[Token(Token = "0x6012C63")]
	[Address(RVA = "0x288E7F4", Offset = "0x288E7F4", VA = "0x288E7F4")]
	public StickerSpriteView()
	{
	}

	[Token(Token = "0x6012C66")]
	[Address(RVA = "0x288E80C", Offset = "0x288E80C", VA = "0x288E80C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012C67")]
	[Address(RVA = "0x288E92C", Offset = "0x288E92C", VA = "0x288E92C")]
	public void SetStickerSprite(ChatStickerData data)
	{
	}

	[Token(Token = "0x6012C68")]
	[Address(RVA = "0x288EA38", Offset = "0x288EA38", VA = "0x288EA38")]
	private void _003CAwake_003Em__0()
	{
	}
}
