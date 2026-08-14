using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AB4")]
public class UIUAVMapObjectView : MonoBehaviour
{
	[Token(Token = "0x4018F46")]
	[FieldOffset(Offset = "0xC")]
	public Transform UAVTemplate;

	[Token(Token = "0x4018F47")]
	[FieldOffset(Offset = "0x10")]
	public UISprite uavCircle;

	[Token(Token = "0x4018F48")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale uavCircleLine;

	[Token(Token = "0x4018F49")]
	[FieldOffset(Offset = "0x18")]
	public UISprite uavIcon;

	[Token(Token = "0x4018F4A")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite uavCircleExtended;

	[Token(Token = "0x60173E3")]
	[Address(RVA = "0x2B7E9E8", Offset = "0x2B7E9E8", VA = "0x2B7E9E8")]
	public UIUAVMapObjectView()
	{
	}
}
