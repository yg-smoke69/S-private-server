using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023A7")]
public class UIHUDSingersBHideAllController : UIBaseController
{
	[Token(Token = "0x20023A8")]
	private sealed class _003CDelayHideTut_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DE08")]
		[FieldOffset(Offset = "0x8")]
		internal bool isShowTut;

		[Token(Token = "0x400DE09")]
		[FieldOffset(Offset = "0xC")]
		internal UIHUDSingersBHideAllController _0024this;

		[Token(Token = "0x400DE0A")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400DE0B")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400DE0C")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170010E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C890")]
			[Address(RVA = "0x2213670", Offset = "0x2213670", VA = "0x2213670", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C891")]
			[Address(RVA = "0x2213678", Offset = "0x2213678", VA = "0x2213678", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C88E")]
		[Address(RVA = "0x2213388", Offset = "0x2213388", VA = "0x2213388")]
		public _003CDelayHideTut_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C88F")]
		[Address(RVA = "0x2213548", Offset = "0x2213548", VA = "0x2213548", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C892")]
		[Address(RVA = "0x2213680", Offset = "0x2213680", VA = "0x2213680", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C893")]
		[Address(RVA = "0x2213694", Offset = "0x2213694", VA = "0x2213694", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DE04")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDSingersBHideAllView m_View;

	[Token(Token = "0x400DE05")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsHideAll;

	[Token(Token = "0x400DE06")]
	public const string ShowTutKey = "UIHUDSingersBHideAllControllerShow";

	[Token(Token = "0x400DE07")]
	public const string HideTutKey = "UIHUDSingersBHideAllControllerHide";

	[Token(Token = "0x170010E3")]
	public bool IsHideAll
	{
		[Token(Token = "0x600C887")]
		[Address(RVA = "0x2212B80", Offset = "0x2212B80", VA = "0x2212B80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600C888")]
		[Address(RVA = "0x2212BD8", Offset = "0x2212BD8", VA = "0x2212BD8")]
		set
		{
		}
	}

	[Token(Token = "0x600C886")]
	[Address(RVA = "0x2212AFC", Offset = "0x2212AFC", VA = "0x2212AFC")]
	public UIHUDSingersBHideAllController()
	{
	}

	[Token(Token = "0x600C889")]
	[Address(RVA = "0x2212F20", Offset = "0x2212F20", VA = "0x2212F20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C88A")]
	[Address(RVA = "0x2212FC8", Offset = "0x2212FC8", VA = "0x2212FC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C88B")]
	[Address(RVA = "0x2212E34", Offset = "0x2212E34", VA = "0x2212E34")]
	private IEnumerator DelayHideTut(bool isShowTut)
	{
		return null;
	}

	[Token(Token = "0x600C88C")]
	[Address(RVA = "0x2213390", Offset = "0x2213390", VA = "0x2213390")]
	private void HideALLUI()
	{
	}

	[Token(Token = "0x600C88D")]
	[Address(RVA = "0x2213540", Offset = "0x2213540", VA = "0x2213540")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
