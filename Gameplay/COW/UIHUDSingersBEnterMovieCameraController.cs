using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023A4")]
public class UIHUDSingersBEnterMovieCameraController : UIBaseController
{
	[Token(Token = "0x20023A5")]
	private sealed class _003CDelayHideTut_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DDFF")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDSingersBEnterMovieCameraController _0024this;

		[Token(Token = "0x400DE00")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DE01")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DE02")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C87D")]
			[Address(RVA = "0x221272C", Offset = "0x221272C", VA = "0x221272C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C87E")]
			[Address(RVA = "0x2212734", Offset = "0x2212734", VA = "0x2212734", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C87B")]
		[Address(RVA = "0x2211E14", Offset = "0x2211E14", VA = "0x2211E14")]
		public _003CDelayHideTut_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C87C")]
		[Address(RVA = "0x221260C", Offset = "0x221260C", VA = "0x221260C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C87F")]
		[Address(RVA = "0x221273C", Offset = "0x221273C", VA = "0x221273C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C880")]
		[Address(RVA = "0x2212750", Offset = "0x2212750", VA = "0x2212750", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DDFB")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDSingersBEnterMovieCameraBtnView m_View;

	[Token(Token = "0x400DDFC")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsInMoive;

	[Token(Token = "0x400DDFD")]
	public const uint SelectedColor = 4294953250u;

	[Token(Token = "0x400DDFE")]
	public const string TutKey = "UIHUDSingersBEnterMovieCameraController";

	[Token(Token = "0x170010E0")]
	public bool IsInMoive
	{
		[Token(Token = "0x600C870")]
		[Address(RVA = "0x22117E0", Offset = "0x22117E0", VA = "0x22117E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600C871")]
		[Address(RVA = "0x2211838", Offset = "0x2211838", VA = "0x2211838")]
		set
		{
		}
	}

	[Token(Token = "0x600C86F")]
	[Address(RVA = "0x221175C", Offset = "0x221175C", VA = "0x221175C")]
	public UIHUDSingersBEnterMovieCameraController()
	{
	}

	[Token(Token = "0x600C872")]
	[Address(RVA = "0x22119B4", Offset = "0x22119B4", VA = "0x22119B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C873")]
	[Address(RVA = "0x2211A5C", Offset = "0x2211A5C", VA = "0x2211A5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C874")]
	[Address(RVA = "0x2211D48", Offset = "0x2211D48", VA = "0x2211D48")]
	private IEnumerator DelayHideTut()
	{
		return null;
	}

	[Token(Token = "0x600C875")]
	[Address(RVA = "0x2211E1C", Offset = "0x2211E1C", VA = "0x2211E1C")]
	private void OnForbiddenMoiveCameraUI(object[] param)
	{
	}

	[Token(Token = "0x600C876")]
	[Address(RVA = "0x2212238", Offset = "0x2212238", VA = "0x2212238")]
	private void OnCloseMoiveCameraUI(object[] param)
	{
	}

	[Token(Token = "0x600C877")]
	[Address(RVA = "0x22122AC", Offset = "0x22122AC", VA = "0x22122AC")]
	private void OnForceEnterMovieCamera(object[] param)
	{
	}

	[Token(Token = "0x600C878")]
	[Address(RVA = "0x22123B0", Offset = "0x22123B0", VA = "0x22123B0")]
	private void OnChangeMovieState()
	{
	}

	[Token(Token = "0x600C879")]
	[Address(RVA = "0x2211F34", Offset = "0x2211F34", VA = "0x2211F34")]
	private void NotifyChangeMoiveState(bool isInMove)
	{
	}

	[Token(Token = "0x600C87A")]
	[Address(RVA = "0x2212604", Offset = "0x2212604", VA = "0x2212604")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
