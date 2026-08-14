using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B4")]
public class UIHUDPVEBossSubtitleController : UIBaseController
{
	[Token(Token = "0x20022B5")]
	private sealed class _003COnShow_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D916")]
		[FieldOffset(Offset = "0x8")]
		internal string content;

		[Token(Token = "0x400D917")]
		[FieldOffset(Offset = "0xC")]
		internal ResourceID voiceResID;

		[Token(Token = "0x400D918")]
		[FieldOffset(Offset = "0x10")]
		internal float duration;

		[Token(Token = "0x400D919")]
		[FieldOffset(Offset = "0x14")]
		internal UIHUDPVEBossSubtitleController _0024this;

		[Token(Token = "0x400D91A")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D91B")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D91C")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001094")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BEE8")]
			[Address(RVA = "0x1681624", Offset = "0x1681624", VA = "0x1681624", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001095")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BEE9")]
			[Address(RVA = "0x168162C", Offset = "0x168162C", VA = "0x168162C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BEE6")]
		[Address(RVA = "0x1681338", Offset = "0x1681338", VA = "0x1681338")]
		public _003COnShow_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BEE7")]
		[Address(RVA = "0x1681348", Offset = "0x1681348", VA = "0x1681348", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BEEA")]
		[Address(RVA = "0x1681634", Offset = "0x1681634", VA = "0x1681634", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BEEB")]
		[Address(RVA = "0x1681648", Offset = "0x1681648", VA = "0x1681648", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D914")]
	[FieldOffset(Offset = "0x28")]
	private HUDPVEBossSubtitleView m_View;

	[Token(Token = "0x400D915")]
	[FieldOffset(Offset = "0x2C")]
	private bool isPlaying;

	[Token(Token = "0x600BEE0")]
	[Address(RVA = "0x1680E74", Offset = "0x1680E74", VA = "0x1680E74")]
	public UIHUDPVEBossSubtitleController()
	{
	}

	[Token(Token = "0x600BEE1")]
	[Address(RVA = "0x1680EF8", Offset = "0x1680EF8", VA = "0x1680EF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEE2")]
	[Address(RVA = "0x1680FA0", Offset = "0x1680FA0", VA = "0x1680FA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEE3")]
	[Address(RVA = "0x1681094", Offset = "0x1681094", VA = "0x1681094")]
	public void OnSubtitleInfoCome(string content, ResourceID voiceResID, float duration)
	{
	}

	[Token(Token = "0x600BEE4")]
	[Address(RVA = "0x16811FC", Offset = "0x16811FC", VA = "0x16811FC")]
	private IEnumerator OnShow(string content, ResourceID voiceResID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600BEE5")]
	[Address(RVA = "0x1681340", Offset = "0x1681340", VA = "0x1681340")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
