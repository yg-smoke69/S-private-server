using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002232")]
public class LadderMatchStar
{
	[Token(Token = "0x400D55B")]
	public const string ANIMATION_GAINSTAR = "UILadderCSMatchStarUp";

	[Token(Token = "0x400D55C")]
	public const string ANIMATION_LOSESTAR = "UILadderCSMatchStarLose";

	[Token(Token = "0x400D55D")]
	[FieldOffset(Offset = "0x8")]
	private GameObject Star;

	[Token(Token = "0x400D55E")]
	[FieldOffset(Offset = "0xC")]
	private Animation StarAnimation;

	[Token(Token = "0x400D55F")]
	[FieldOffset(Offset = "0x10")]
	private Transform OnState;

	[Token(Token = "0x600B96A")]
	[Address(RVA = "0x1EF5968", Offset = "0x1EF5968", VA = "0x1EF5968")]
	public LadderMatchStar()
	{
	}

	[Token(Token = "0x600B96B")]
	[Address(RVA = "0x1EF5970", Offset = "0x1EF5970", VA = "0x1EF5970")]
	public void InitStar(GameObject star, Transform parent)
	{
	}

	[Token(Token = "0x600B96C")]
	[Address(RVA = "0x1EF5CD4", Offset = "0x1EF5CD4", VA = "0x1EF5CD4")]
	public void SetStarActive(bool enable)
	{
	}

	[Token(Token = "0x600B96D")]
	[Address(RVA = "0x1EF5D58", Offset = "0x1EF5D58", VA = "0x1EF5D58")]
	public void SetStarOn()
	{
	}

	[Token(Token = "0x600B96E")]
	[Address(RVA = "0x1EF5E84", Offset = "0x1EF5E84", VA = "0x1EF5E84")]
	public void SetStarOff()
	{
	}

	[Token(Token = "0x600B96F")]
	[Address(RVA = "0x1EF5FB0", Offset = "0x1EF5FB0", VA = "0x1EF5FB0")]
	public Animation GetStarAnimation()
	{
		return null;
	}

	[Token(Token = "0x600B970")]
	[Address(RVA = "0x1EF6008", Offset = "0x1EF6008", VA = "0x1EF6008")]
	public bool ResetAnimOnEnable(bool b)
	{
		return default(bool);
	}

	[Token(Token = "0x600B971")]
	[Address(RVA = "0x1EF6138", Offset = "0x1EF6138", VA = "0x1EF6138")]
	public void SetStarOnAlpha(float a)
	{
	}
}
