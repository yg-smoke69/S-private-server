using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A54")]
internal class CommonAnimationEffect : ReusableObject
{
	[Token(Token = "0x4005BB2")]
	[FieldOffset(Offset = "0x18")]
	protected Animator[] m_Animators;

	[Token(Token = "0x4005BB3")]
	[FieldOffset(Offset = "0x1C")]
	protected Animation[] m_Animations;

	[Token(Token = "0x600501E")]
	[Address(RVA = "0x1737540", Offset = "0x1737540", VA = "0x1737540")]
	public CommonAnimationEffect()
	{
	}

	[Token(Token = "0x600501F")]
	[Address(RVA = "0x1737548", Offset = "0x1737548", VA = "0x1737548")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005020")]
	[Address(RVA = "0x173765C", Offset = "0x173765C", VA = "0x173765C")]
	public void Play()
	{
	}
}
