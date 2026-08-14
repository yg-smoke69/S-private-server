using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200239B")]
public class ToneCompleteEffectControl : MonoBehaviour
{
	[Token(Token = "0x400DDCB")]
	private const string perfect_label_color = "#FDC121";

	[Token(Token = "0x400DDCC")]
	private const string perfect_bg_color = "#BC7F4D";

	[Token(Token = "0x400DDCD")]
	private const string perfect_tex_color = "#FFFFFF";

	[Token(Token = "0x400DDCE")]
	private const string good_label_color = "#FE76FF";

	[Token(Token = "0x400DDCF")]
	private const string good_bg_color = "#DA65E0";

	[Token(Token = "0x400DDD0")]
	private const string good_tex_color = "#FFC0BB";

	[Token(Token = "0x400DDD1")]
	private const string complete_label_color = "#87CFF0";

	[Token(Token = "0x400DDD2")]
	private const string complete_bg_color = "#65AAFE";

	[Token(Token = "0x400DDD3")]
	private const string complete_tex_color = "#5BB0EA";

	[Token(Token = "0x400DDD4")]
	[FieldOffset(Offset = "0xC")]
	public UILabel typeLabel;

	[Token(Token = "0x400DDD5")]
	[FieldOffset(Offset = "0x10")]
	public UISprite bg;

	[Token(Token = "0x400DDD6")]
	[FieldOffset(Offset = "0x14")]
	public UITexture vfxTex;

	[Token(Token = "0x400DDD7")]
	[FieldOffset(Offset = "0x18")]
	private float showTime;

	[Token(Token = "0x600C809")]
	[Address(RVA = "0x28AF438", Offset = "0x28AF438", VA = "0x28AF438")]
	public ToneCompleteEffectControl()
	{
	}

	[Token(Token = "0x600C80A")]
	[Address(RVA = "0x28AF448", Offset = "0x28AF448", VA = "0x28AF448")]
	public void StartEffect(ToneCompleteType type)
	{
	}

	[Token(Token = "0x600C80B")]
	[Address(RVA = "0x28AFB78", Offset = "0x28AFB78", VA = "0x28AFB78")]
	public void PoolReturnNow()
	{
	}

	[Token(Token = "0x600C80C")]
	[Address(RVA = "0x28AF5E0", Offset = "0x28AF5E0", VA = "0x28AF5E0")]
	private void ShowPerfect()
	{
	}

	[Token(Token = "0x600C80D")]
	[Address(RVA = "0x28AF79C", Offset = "0x28AF79C", VA = "0x28AF79C")]
	private void ShowGood()
	{
	}

	[Token(Token = "0x600C80E")]
	[Address(RVA = "0x28AF958", Offset = "0x28AF958", VA = "0x28AF958")]
	private void ShowComplete()
	{
	}

	[Token(Token = "0x600C80F")]
	[Address(RVA = "0x28AFB14", Offset = "0x28AFB14", VA = "0x28AFB14")]
	private void ShowMiss()
	{
	}

	[Token(Token = "0x600C810")]
	[Address(RVA = "0x28AFDE0", Offset = "0x28AFDE0", VA = "0x28AFDE0")]
	private Color HexString2Color(string hexColor)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600C811")]
	[Address(RVA = "0x28AFCB4", Offset = "0x28AFCB4", VA = "0x28AFCB4")]
	private void ChangeAllShowActiveStatus(bool isActive)
	{
	}
}
