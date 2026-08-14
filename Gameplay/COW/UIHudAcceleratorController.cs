using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026CA")]
internal class UIHudAcceleratorController : UIHudVehicleButtonBaseController
{
	[Token(Token = "0x20026CB")]
	private sealed class _003CCheckInputTouch_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EF69")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudAcceleratorController _0024this;

		[Token(Token = "0x400EF6A")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400EF6B")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400EF6C")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EA93")]
			[Address(RVA = "0x163D78C", Offset = "0x163D78C", VA = "0x163D78C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EA94")]
			[Address(RVA = "0x163D794", Offset = "0x163D794", VA = "0x163D794", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EA91")]
		[Address(RVA = "0x163D268", Offset = "0x163D268", VA = "0x163D268")]
		public _003CCheckInputTouch_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EA92")]
		[Address(RVA = "0x163D384", Offset = "0x163D384", VA = "0x163D384", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EA95")]
		[Address(RVA = "0x163D79C", Offset = "0x163D79C", VA = "0x163D79C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EA96")]
		[Address(RVA = "0x163D7B0", Offset = "0x163D7B0", VA = "0x163D7B0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400EF68")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudAcceleratorView m_View;

	[Token(Token = "0x600EA86")]
	[Address(RVA = "0x163CF04", Offset = "0x163CF04", VA = "0x163CF04")]
	public UIHudAcceleratorController()
	{
	}

	[Token(Token = "0x600EA87")]
	[Address(RVA = "0x163CF0C", Offset = "0x163CF0C", VA = "0x163CF0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA88")]
	[Address(RVA = "0x163CFB0", Offset = "0x163CFB0", VA = "0x163CFB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA89")]
	[Address(RVA = "0x163D090", Offset = "0x163D090", VA = "0x163D090", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA8A")]
	[Address(RVA = "0x163D0F4", Offset = "0x163D0F4", VA = "0x163D0F4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EA8B")]
	[Address(RVA = "0x163D19C", Offset = "0x163D19C", VA = "0x163D19C")]
	private IEnumerator CheckInputTouch()
	{
		return null;
	}

	[Token(Token = "0x600EA8C")]
	[Address(RVA = "0x163D270", Offset = "0x163D270", VA = "0x163D270", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EA8D")]
	[Address(RVA = "0x163D314", Offset = "0x163D314", VA = "0x163D314", Slot = "37")]
	protected override EControlMode ShowInControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x600EA8E")]
	[Address(RVA = "0x163D36C", Offset = "0x163D36C", VA = "0x163D36C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EA8F")]
	[Address(RVA = "0x163D374", Offset = "0x163D374", VA = "0x163D374")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EA90")]
	[Address(RVA = "0x163D37C", Offset = "0x163D37C", VA = "0x163D37C")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
