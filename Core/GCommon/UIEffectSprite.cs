using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004144")]
public class UIEffectSprite : UISprite
{
	[Token(Token = "0x401B64B")]
	[FieldOffset(Offset = "0x1D4")]
	public GameObject Effect;

	[Token(Token = "0x401B64C")]
	[FieldOffset(Offset = "0x1D8")]
	public float EffectScale;

	[Token(Token = "0x401B64D")]
	private const int HEADSPRITE_WIDTH = 60;

	[Token(Token = "0x401B64E")]
	private const int HEADSPRITE_HEIGHT = 60;

	[Token(Token = "0x601AAC0")]
	[Address(RVA = "0x2CA2C9C", Offset = "0x2CA2C9C", VA = "0x2CA2C9C")]
	public UIEffectSprite()
	{
	}

	[Token(Token = "0x601AAC1")]
	[Address(RVA = "0x2CA2D20", Offset = "0x2CA2D20", VA = "0x2CA2D20", Slot = "18")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x601AAC2")]
	[Address(RVA = "0x2CA302C", Offset = "0x2CA302C", VA = "0x2CA302C")]
	public void SetEffect(ResourceID effectResID)
	{
	}

	[Token(Token = "0x601AAC3")]
	[Address(RVA = "0x2CA31D8", Offset = "0x2CA31D8", VA = "0x2CA31D8")]
	private void SetEffectClip(GameObject effect)
	{
	}

	[Token(Token = "0x601AAC4")]
	[Address(RVA = "0x2CA2D48", Offset = "0x2CA2D48", VA = "0x2CA2D48")]
	public void SetEffect(GameObject effect, bool needRemove = true)
	{
	}

	[Token(Token = "0x601AAC5")]
	[Address(RVA = "0x2CA3818", Offset = "0x2CA3818", VA = "0x2CA3818")]
	public void UpdateEffectScale(Vector2 size)
	{
	}

	[Token(Token = "0x601AAC6")]
	[Address(RVA = "0x2CA3710", Offset = "0x2CA3710", VA = "0x2CA3710")]
	private void SetEffectScale()
	{
	}

	[Token(Token = "0x601AAC7")]
	[Address(RVA = "0x2CA3508", Offset = "0x2CA3508", VA = "0x2CA3508")]
	private void SetEffeectPosition()
	{
	}

	[Token(Token = "0x601AAC8")]
	[Address(RVA = "0x2CA3430", Offset = "0x2CA3430", VA = "0x2CA3430")]
	public void RemoveEffect()
	{
	}
}
