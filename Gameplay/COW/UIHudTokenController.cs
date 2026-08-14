using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023D3")]
public class UIHudTokenController : UIBaseController
{
	[Token(Token = "0x20023D4")]
	private sealed class _003CCoPlayPlayEffect_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DEBC")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudTokenController _0024this;

		[Token(Token = "0x400DEBD")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DEBE")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DEBF")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600CA1C")]
			[Address(RVA = "0x1581888", Offset = "0x1581888", VA = "0x1581888", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600CA1D")]
			[Address(RVA = "0x1581890", Offset = "0x1581890", VA = "0x1581890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600CA1A")]
		[Address(RVA = "0x1581260", Offset = "0x1581260", VA = "0x1581260")]
		public _003CCoPlayPlayEffect_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600CA1B")]
		[Address(RVA = "0x15816EC", Offset = "0x15816EC", VA = "0x15816EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600CA1E")]
		[Address(RVA = "0x1581898", Offset = "0x1581898", VA = "0x1581898", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600CA1F")]
		[Address(RVA = "0x15818AC", Offset = "0x15818AC", VA = "0x15818AC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20023D5")]
	private sealed class _003CUpdateBuySelfReviveState_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DEC0")]
		[FieldOffset(Offset = "0x8")]
		internal PHBPHCPPNDI game;

		[Token(Token = "0x400DEC1")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CcurrTime_003E__1;

		[Token(Token = "0x400DEC2")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudTokenController _0024this;

		[Token(Token = "0x400DEC3")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400DEC4")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400DEC5")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170010E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600CA22")]
			[Address(RVA = "0x1582194", Offset = "0x1582194", VA = "0x1582194", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600CA23")]
			[Address(RVA = "0x158219C", Offset = "0x158219C", VA = "0x158219C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600CA20")]
		[Address(RVA = "0x158168C", Offset = "0x158168C", VA = "0x158168C")]
		public _003CUpdateBuySelfReviveState_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600CA21")]
		[Address(RVA = "0x1581934", Offset = "0x1581934", VA = "0x1581934", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600CA24")]
		[Address(RVA = "0x15821A4", Offset = "0x15821A4", VA = "0x15821A4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600CA25")]
		[Address(RVA = "0x15821B8", Offset = "0x15821B8", VA = "0x15821B8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DEB6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTokenView m_View;

	[Token(Token = "0x400DEB7")]
	[FieldOffset(Offset = "0x2C")]
	private IEnumerator m_PlayEffectCor;

	[Token(Token = "0x400DEB8")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsPlayEff;

	[Token(Token = "0x400DEB9")]
	[FieldOffset(Offset = "0x34")]
	private int m_TokenNum;

	[Token(Token = "0x400DEBA")]
	[FieldOffset(Offset = "0x38")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x400DEBB")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_buyReviveStart;

	[Token(Token = "0x600CA08")]
	[Address(RVA = "0x157FB5C", Offset = "0x157FB5C", VA = "0x157FB5C")]
	public UIHudTokenController()
	{
	}

	[Token(Token = "0x600CA09")]
	[Address(RVA = "0x157FBE0", Offset = "0x157FBE0", VA = "0x157FBE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA0A")]
	[Address(RVA = "0x157FC88", Offset = "0x157FC88", VA = "0x157FC88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA0B")]
	[Address(RVA = "0x158075C", Offset = "0x158075C", VA = "0x158075C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600CA0C")]
	[Address(RVA = "0x1580268", Offset = "0x1580268", VA = "0x1580268")]
	private void InitRevivalState()
	{
	}

	[Token(Token = "0x600CA0D")]
	[Address(RVA = "0x157FFA8", Offset = "0x157FFA8", VA = "0x157FFA8")]
	private void InitLables()
	{
	}

	[Token(Token = "0x600CA0E")]
	[Address(RVA = "0x1580BEC", Offset = "0x1580BEC", VA = "0x1580BEC")]
	private void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600CA0F")]
	[Address(RVA = "0x1580F04", Offset = "0x1580F04", VA = "0x1580F04")]
	private IEnumerator CoPlayPlayEffect()
	{
		return null;
	}

	[Token(Token = "0x600CA10")]
	[Address(RVA = "0x1581268", Offset = "0x1581268", VA = "0x1581268", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CA11")]
	[Address(RVA = "0x1581364", Offset = "0x1581364", VA = "0x1581364")]
	private void OnRevivalBtnClick()
	{
	}

	[Token(Token = "0x600CA12")]
	[Address(RVA = "0x1580A34", Offset = "0x1580A34", VA = "0x1580A34")]
	private void RefreshAutoRevivalState(byte autoRevivalState)
	{
	}

	[Token(Token = "0x600CA13")]
	[Address(RVA = "0x1581474", Offset = "0x1581474", VA = "0x1581474")]
	private void OnTokenAutoRevival(object[] data)
	{
	}

	[Token(Token = "0x600CA14")]
	[Address(RVA = "0x158154C", Offset = "0x158154C", VA = "0x158154C")]
	private void OnPlayerAliveStateChange(object[] data)
	{
	}

	[Token(Token = "0x600CA15")]
	[Address(RVA = "0x1580FD0", Offset = "0x1580FD0", VA = "0x1580FD0")]
	private void UpdateBuySelfReviveCost(object[] data)
	{
	}

	[Token(Token = "0x600CA16")]
	[Address(RVA = "0x1580948", Offset = "0x1580948", VA = "0x1580948")]
	private IEnumerator UpdateBuySelfReviveState(PHBPHCPPNDI game)
	{
		return null;
	}

	[Token(Token = "0x600CA17")]
	[Address(RVA = "0x1581694", Offset = "0x1581694", VA = "0x1581694")]
	private void _003COnEnable_003Em__0(GameObject go, bool v)
	{
	}

	[Token(Token = "0x600CA18")]
	[Address(RVA = "0x15816DC", Offset = "0x15816DC", VA = "0x15816DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA19")]
	[Address(RVA = "0x15816E4", Offset = "0x15816E4", VA = "0x15816E4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
