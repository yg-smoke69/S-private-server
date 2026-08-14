using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026DC")]
internal class UIHudAutoFireSwitchController : UIBaseController
{
	[Token(Token = "0x20026DD")]
	private sealed class _003CShowTutorialForAutoFire_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F002")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudAutoFireSwitchController _0024this;

		[Token(Token = "0x400F003")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F004")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F005")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EB44")]
			[Address(RVA = "0x170CD04", Offset = "0x170CD04", VA = "0x170CD04", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EB45")]
			[Address(RVA = "0x170CD0C", Offset = "0x170CD0C", VA = "0x170CD0C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EB42")]
		[Address(RVA = "0x170C49C", Offset = "0x170C49C", VA = "0x170C49C")]
		public _003CShowTutorialForAutoFire_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EB43")]
		[Address(RVA = "0x170CB5C", Offset = "0x170CB5C", VA = "0x170CB5C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EB46")]
		[Address(RVA = "0x170CD14", Offset = "0x170CD14", VA = "0x170CD14", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EB47")]
		[Address(RVA = "0x170CD28", Offset = "0x170CD28", VA = "0x170CD28", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F001")]
	[FieldOffset(Offset = "0x28")]
	private UIHudAutoFireSwitchView m_View;

	[Token(Token = "0x600EB35")]
	[Address(RVA = "0x170C03C", Offset = "0x170C03C", VA = "0x170C03C")]
	public UIHudAutoFireSwitchController()
	{
	}

	[Token(Token = "0x600EB36")]
	[Address(RVA = "0x170C0C0", Offset = "0x170C0C0", VA = "0x170C0C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB37")]
	[Address(RVA = "0x170C164", Offset = "0x170C164", VA = "0x170C164", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB38")]
	[Address(RVA = "0x170C438", Offset = "0x170C438", VA = "0x170C438", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EB39")]
	[Address(RVA = "0x170C36C", Offset = "0x170C36C", VA = "0x170C36C")]
	private IEnumerator ShowTutorialForAutoFire()
	{
		return null;
	}

	[Token(Token = "0x600EB3A")]
	[Address(RVA = "0x170C4A4", Offset = "0x170C4A4", VA = "0x170C4A4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EB3B")]
	[Address(RVA = "0x170C808", Offset = "0x170C808", VA = "0x170C808")]
	private void OnBtnFireModeSwitch()
	{
	}

	[Token(Token = "0x600EB3C")]
	[Address(RVA = "0x170C510", Offset = "0x170C510", VA = "0x170C510")]
	private void OnFireModeChanged()
	{
	}

	[Token(Token = "0x600EB3D")]
	[Address(RVA = "0x170C9E8", Offset = "0x170C9E8", VA = "0x170C9E8")]
	private void ShowTutorialAutoFire(object[] param)
	{
	}

	[Token(Token = "0x600EB3E")]
	[Address(RVA = "0x170C8E4", Offset = "0x170C8E4", VA = "0x170C8E4")]
	private void UpdateIcon()
	{
	}

	[Token(Token = "0x600EB3F")]
	[Address(RVA = "0x170CB44", Offset = "0x170CB44", VA = "0x170CB44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB40")]
	[Address(RVA = "0x170CB4C", Offset = "0x170CB4C", VA = "0x170CB4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EB41")]
	[Address(RVA = "0x170CB54", Offset = "0x170CB54", VA = "0x170CB54")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
