using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D12")]
public class UIHudEmotionItem : MonoBehaviour
{
	[Token(Token = "0x4011321")]
	[FieldOffset(Offset = "0xC")]
	public UIButton BtnEmotionItem;

	[Token(Token = "0x4011322")]
	[FieldOffset(Offset = "0x10")]
	public UISprite iconEmotionItem;

	[Token(Token = "0x4011323")]
	[FieldOffset(Offset = "0x14")]
	public Transform EmotionPos;

	[Token(Token = "0x4011324")]
	[FieldOffset(Offset = "0x18")]
	private uint m_EmotionID;

	[Token(Token = "0x6012D88")]
	[Address(RVA = "0x1CE1F2C", Offset = "0x1CE1F2C", VA = "0x1CE1F2C")]
	public UIHudEmotionItem()
	{
	}

	[Token(Token = "0x6012D89")]
	[Address(RVA = "0x1CDFE08", Offset = "0x1CDFE08", VA = "0x1CDFE08")]
	public void InitInfo(uint emotionID)
	{
	}

	[Token(Token = "0x6012D8A")]
	[Address(RVA = "0x1CE1F34", Offset = "0x1CE1F34", VA = "0x1CE1F34")]
	private void OnBtnEmotionClick()
	{
	}
}
