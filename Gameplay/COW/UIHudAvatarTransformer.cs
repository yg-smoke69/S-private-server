using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D0D")]
public class UIHudAvatarTransformer : MonoBehaviour
{
	[Token(Token = "0x2002D0E")]
	private sealed class _003COnBtnTransformClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011319")]
		[FieldOffset(Offset = "0x8")]
		internal Player localPlayer;

		[Token(Token = "0x401131A")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudAvatarTransformer _0024this;

		[Token(Token = "0x6012D80")]
		[Address(RVA = "0x1713FAC", Offset = "0x1713FAC", VA = "0x1713FAC")]
		public _003COnBtnTransformClick_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2002D0F")]
	private sealed class _003COnBtnTransformClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x401131B")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID animId;

		[Token(Token = "0x401131C")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnBtnTransformClick_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x6012D81")]
		[Address(RVA = "0x1713FB4", Offset = "0x1713FB4", VA = "0x1713FB4")]
		public _003COnBtnTransformClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012D82")]
		[Address(RVA = "0x1714608", Offset = "0x1714608", VA = "0x1714608")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6012D83")]
		[Address(RVA = "0x1714870", Offset = "0x1714870", VA = "0x1714870")]
		internal bool _003C_003Em__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002D10")]
	private sealed class _003COnBtnTransformBackClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x401131D")]
		[FieldOffset(Offset = "0x8")]
		internal Player localPlayer;

		[Token(Token = "0x401131E")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudAvatarTransformer _0024this;

		[Token(Token = "0x6012D84")]
		[Address(RVA = "0x17142D8", Offset = "0x17142D8", VA = "0x17142D8")]
		public _003COnBtnTransformBackClick_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x2002D11")]
	private sealed class _003COnBtnTransformBackClick_003Ec__AnonStorey3
	{
		[Token(Token = "0x401131F")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID animId;

		[Token(Token = "0x4011320")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnBtnTransformBackClick_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x6012D85")]
		[Address(RVA = "0x17142E0", Offset = "0x17142E0", VA = "0x17142E0")]
		public _003COnBtnTransformBackClick_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012D86")]
		[Address(RVA = "0x17142E8", Offset = "0x17142E8", VA = "0x17142E8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6012D87")]
		[Address(RVA = "0x17144F8", Offset = "0x17144F8", VA = "0x17144F8")]
		internal bool _003C_003Em__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011314")]
	[FieldOffset(Offset = "0xC")]
	public UIButton TransformBtn;

	[Token(Token = "0x4011315")]
	[FieldOffset(Offset = "0x10")]
	public UIButton TransformerBackBtn;

	[Token(Token = "0x4011316")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Transforming;

	[Token(Token = "0x4011317")]
	[FieldOffset(Offset = "0x18")]
	public GameObject downLoad;

	[Token(Token = "0x4011318")]
	[FieldOffset(Offset = "0x1C")]
	private TransformData m_transformData;

	[Token(Token = "0x6012D79")]
	[Address(RVA = "0x1712B84", Offset = "0x1712B84", VA = "0x1712B84")]
	public UIHudAvatarTransformer()
	{
	}

	[Token(Token = "0x6012D7A")]
	[Address(RVA = "0x1712B8C", Offset = "0x1712B8C", VA = "0x1712B8C")]
	public void Init(uint transformerId)
	{
	}

	[Token(Token = "0x6012D7B")]
	[Address(RVA = "0x1712F9C", Offset = "0x1712F9C", VA = "0x1712F9C")]
	private void OnTryTransform()
	{
	}

	[Token(Token = "0x6012D7C")]
	[Address(RVA = "0x1713DB8", Offset = "0x1713DB8", VA = "0x1713DB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012D7D")]
	[Address(RVA = "0x1713674", Offset = "0x1713674", VA = "0x1713674")]
	private void OnBtnTransformClick()
	{
	}

	[Token(Token = "0x6012D7E")]
	[Address(RVA = "0x1713FBC", Offset = "0x1713FBC", VA = "0x1713FBC")]
	private bool isCanChange()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D7F")]
	[Address(RVA = "0x17130E4", Offset = "0x17130E4", VA = "0x17130E4")]
	private void OnBtnTransformBackClick()
	{
	}
}
