using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EC0")]
public class UIDigitaluniverseBGalaxyCanvasController : UIBaseController, _Attribute
{
	[Token(Token = "0x2001EC1")]
	private sealed class _003CPlayEnterAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1A0")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400C1A1")]
		[FieldOffset(Offset = "0xC")]
		internal LinkedList<ulong> _003ClinkList_003E__2;

		[Token(Token = "0x400C1A2")]
		[FieldOffset(Offset = "0x10")]
		internal LinkedListNode<ulong> _003ClistNode_003E__3;

		[Token(Token = "0x400C1A3")]
		[FieldOffset(Offset = "0x18")]
		internal ulong _003CaccountId_003E__4;

		[Token(Token = "0x400C1A4")]
		[FieldOffset(Offset = "0x20")]
		internal UIDigitaluniverseBCoreController _003CctrlCore_003E__4;

		[Token(Token = "0x400C1A5")]
		[FieldOffset(Offset = "0x24")]
		internal UIDigitaluniverseBStarLineController _003Cctrl_003E__4;

		[Token(Token = "0x400C1A6")]
		[FieldOffset(Offset = "0x28")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1A7")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x400C1A8")]
		[FieldOffset(Offset = "0x30")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1A9")]
		[FieldOffset(Offset = "0x34")]
		internal int _0024PC;

		[Token(Token = "0x17000F46")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009591")]
			[Address(RVA = "0x2F62C28", Offset = "0x2F62C28", VA = "0x2F62C28", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F47")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009592")]
			[Address(RVA = "0x2F62C30", Offset = "0x2F62C30", VA = "0x2F62C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600958F")]
		[Address(RVA = "0x2F62750", Offset = "0x2F62750", VA = "0x2F62750")]
		public _003CPlayEnterAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009590")]
		[Address(RVA = "0x2F62758", Offset = "0x2F62758", VA = "0x2F62758", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009593")]
		[Address(RVA = "0x2F62C38", Offset = "0x2F62C38", VA = "0x2F62C38", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009594")]
		[Address(RVA = "0x2F62C4C", Offset = "0x2F62C4C", VA = "0x2F62C4C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC2")]
	private sealed class _003CPlayMoveAnimation_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1AA")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBStarMapController _003CpCtrl_003E__0;

		[Token(Token = "0x400C1AB")]
		[FieldOffset(Offset = "0x10")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1AC")]
		[FieldOffset(Offset = "0x18")]
		internal ulong[] before_neighbors;

		[Token(Token = "0x400C1AD")]
		[FieldOffset(Offset = "0x1C")]
		internal ulong[] after_neighbors;

		[Token(Token = "0x400C1AE")]
		[FieldOffset(Offset = "0x20")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1AF")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400C1B0")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1B1")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17000F48")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009597")]
			[Address(RVA = "0x2F6353C", Offset = "0x2F6353C", VA = "0x2F6353C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F49")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009598")]
			[Address(RVA = "0x2F63544", Offset = "0x2F63544", VA = "0x2F63544", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009595")]
		[Address(RVA = "0x2F631B8", Offset = "0x2F631B8", VA = "0x2F631B8")]
		public _003CPlayMoveAnimation_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6009596")]
		[Address(RVA = "0x2F631C0", Offset = "0x2F631C0", VA = "0x2F631C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009599")]
		[Address(RVA = "0x2F6354C", Offset = "0x2F6354C", VA = "0x2F6354C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600959A")]
		[Address(RVA = "0x2F63560", Offset = "0x2F63560", VA = "0x2F63560", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC3")]
	private sealed class _003CPlayExchangeAnimation_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1B2")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBStarMapController _003CpCtrl_003E__0;

		[Token(Token = "0x400C1B3")]
		[FieldOffset(Offset = "0x10")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1B4")]
		[FieldOffset(Offset = "0x18")]
		internal ulong targetAccountId;

		[Token(Token = "0x400C1B5")]
		[FieldOffset(Offset = "0x20")]
		internal ulong[] beforeAccounts;

		[Token(Token = "0x400C1B6")]
		[FieldOffset(Offset = "0x24")]
		internal ulong[] afterAccounts;

		[Token(Token = "0x400C1B7")]
		[FieldOffset(Offset = "0x28")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1B8")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x400C1B9")]
		[FieldOffset(Offset = "0x30")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1BA")]
		[FieldOffset(Offset = "0x34")]
		internal int _0024PC;

		[Token(Token = "0x17000F4A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600959D")]
			[Address(RVA = "0x2F6310C", Offset = "0x2F6310C", VA = "0x2F6310C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600959E")]
			[Address(RVA = "0x2F63114", Offset = "0x2F63114", VA = "0x2F63114", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600959B")]
		[Address(RVA = "0x2F62CD4", Offset = "0x2F62CD4", VA = "0x2F62CD4")]
		public _003CPlayExchangeAnimation_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600959C")]
		[Address(RVA = "0x2F62CDC", Offset = "0x2F62CDC", VA = "0x2F62CDC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600959F")]
		[Address(RVA = "0x2F6311C", Offset = "0x2F6311C", VA = "0x2F6311C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095A0")]
		[Address(RVA = "0x2F63130", Offset = "0x2F63130", VA = "0x2F63130", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC4")]
	private sealed class _003CPlayDisappearLinesAnimationMove_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1BB")]
		[FieldOffset(Offset = "0x8")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1BC")]
		[FieldOffset(Offset = "0x10")]
		internal ulong[] after_neighbors;

		[Token(Token = "0x400C1BD")]
		[FieldOffset(Offset = "0x14")]
		internal ulong[] before_neighbors;

		[Token(Token = "0x400C1BE")]
		[FieldOffset(Offset = "0x18")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1BF")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400C1C0")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1C1")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17000F4C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095A3")]
			[Address(RVA = "0x2F620A8", Offset = "0x2F620A8", VA = "0x2F620A8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095A4")]
			[Address(RVA = "0x2F620B0", Offset = "0x2F620B0", VA = "0x2F620B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095A1")]
		[Address(RVA = "0x2F61E6C", Offset = "0x2F61E6C", VA = "0x2F61E6C")]
		public _003CPlayDisappearLinesAnimationMove_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x60095A2")]
		[Address(RVA = "0x2F61E74", Offset = "0x2F61E74", VA = "0x2F61E74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095A5")]
		[Address(RVA = "0x2F620B8", Offset = "0x2F620B8", VA = "0x2F620B8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095A6")]
		[Address(RVA = "0x2F620CC", Offset = "0x2F620CC", VA = "0x2F620CC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC5")]
	private sealed class _003CPlayDisappearLinesAnimationExchange_003Ec__Iterator4 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1C2")]
		[FieldOffset(Offset = "0x8")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1C3")]
		[FieldOffset(Offset = "0x10")]
		internal ulong[] beforeAccounts;

		[Token(Token = "0x400C1C4")]
		[FieldOffset(Offset = "0x18")]
		internal ulong targetAccountId;

		[Token(Token = "0x400C1C5")]
		[FieldOffset(Offset = "0x20")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1C6")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400C1C7")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1C8")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17000F4E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095A9")]
			[Address(RVA = "0x2F61DC0", Offset = "0x2F61DC0", VA = "0x2F61DC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095AA")]
			[Address(RVA = "0x2F61DC8", Offset = "0x2F61DC8", VA = "0x2F61DC8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095A7")]
		[Address(RVA = "0x2F61BF4", Offset = "0x2F61BF4", VA = "0x2F61BF4")]
		public _003CPlayDisappearLinesAnimationExchange_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x60095A8")]
		[Address(RVA = "0x2F61BFC", Offset = "0x2F61BFC", VA = "0x2F61BFC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095AB")]
		[Address(RVA = "0x2F61DD0", Offset = "0x2F61DD0", VA = "0x2F61DD0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095AC")]
		[Address(RVA = "0x2F61DE4", Offset = "0x2F61DE4", VA = "0x2F61DE4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC6")]
	private sealed class _003CPlayDrawLineAnimationMove_003Ec__Iterator5 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1C9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong[] before_neighbors;

		[Token(Token = "0x400C1CA")]
		[FieldOffset(Offset = "0x10")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1CB")]
		[FieldOffset(Offset = "0x18")]
		internal ulong[] after_neighbors;

		[Token(Token = "0x400C1CC")]
		[FieldOffset(Offset = "0x1C")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1CD")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400C1CE")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1CF")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000F50")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095AF")]
			[Address(RVA = "0x2F626A4", Offset = "0x2F626A4", VA = "0x2F626A4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F51")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095B0")]
			[Address(RVA = "0x2F626AC", Offset = "0x2F626AC", VA = "0x2F626AC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095AD")]
		[Address(RVA = "0x2F6247C", Offset = "0x2F6247C", VA = "0x2F6247C")]
		public _003CPlayDrawLineAnimationMove_003Ec__Iterator5()
		{
		}

		[Token(Token = "0x60095AE")]
		[Address(RVA = "0x2F62484", Offset = "0x2F62484", VA = "0x2F62484", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095B1")]
		[Address(RVA = "0x2F626B4", Offset = "0x2F626B4", VA = "0x2F626B4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095B2")]
		[Address(RVA = "0x2F626C8", Offset = "0x2F626C8", VA = "0x2F626C8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC7")]
	private sealed class _003CPlayDrawLineAnimationExchange_003Ec__Iterator6 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1D0")]
		[FieldOffset(Offset = "0x8")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1D1")]
		[FieldOffset(Offset = "0x10")]
		internal ulong[] afterAccounts;

		[Token(Token = "0x400C1D2")]
		[FieldOffset(Offset = "0x18")]
		internal ulong targetAccountId;

		[Token(Token = "0x400C1D3")]
		[FieldOffset(Offset = "0x20")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1D4")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400C1D5")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1D6")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17000F52")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095B5")]
			[Address(RVA = "0x2F623D0", Offset = "0x2F623D0", VA = "0x2F623D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F53")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095B6")]
			[Address(RVA = "0x2F623D8", Offset = "0x2F623D8", VA = "0x2F623D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095B3")]
		[Address(RVA = "0x2F62154", Offset = "0x2F62154", VA = "0x2F62154")]
		public _003CPlayDrawLineAnimationExchange_003Ec__Iterator6()
		{
		}

		[Token(Token = "0x60095B4")]
		[Address(RVA = "0x2F6215C", Offset = "0x2F6215C", VA = "0x2F6215C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095B7")]
		[Address(RVA = "0x2F623E0", Offset = "0x2F623E0", VA = "0x2F623E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095B8")]
		[Address(RVA = "0x2F623F4", Offset = "0x2F623F4", VA = "0x2F623F4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC8")]
	private sealed class _003CPlayMoveCoreAnimationMove_003Ec__Iterator7 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1D7")]
		[FieldOffset(Offset = "0x8")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1D8")]
		[FieldOffset(Offset = "0x10")]
		internal UIDigitaluniverseBCoreController _003Cctrl_003E__0;

		[Token(Token = "0x400C1D9")]
		[FieldOffset(Offset = "0x14")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1DA")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400C1DB")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1DC")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17000F54")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095BB")]
			[Address(RVA = "0x2F63818", Offset = "0x2F63818", VA = "0x2F63818", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F55")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095BC")]
			[Address(RVA = "0x2F63820", Offset = "0x2F63820", VA = "0x2F63820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095B9")]
		[Address(RVA = "0x2F635E8", Offset = "0x2F635E8", VA = "0x2F635E8")]
		public _003CPlayMoveCoreAnimationMove_003Ec__Iterator7()
		{
		}

		[Token(Token = "0x60095BA")]
		[Address(RVA = "0x2F635F0", Offset = "0x2F635F0", VA = "0x2F635F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095BD")]
		[Address(RVA = "0x2F63828", Offset = "0x2F63828", VA = "0x2F63828", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095BE")]
		[Address(RVA = "0x2F6383C", Offset = "0x2F6383C", VA = "0x2F6383C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EC9")]
	private sealed class _003CPlayMoveCoresAnimationExchange_003Ec__Iterator8 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C1DD")]
		[FieldOffset(Offset = "0x8")]
		internal ulong curAccountId;

		[Token(Token = "0x400C1DE")]
		[FieldOffset(Offset = "0x10")]
		internal UIDigitaluniverseBCoreController _003CcurCtrl_003E__0;

		[Token(Token = "0x400C1DF")]
		[FieldOffset(Offset = "0x18")]
		internal ulong targetAccountId;

		[Token(Token = "0x400C1E0")]
		[FieldOffset(Offset = "0x20")]
		internal UIDigitaluniverseBCoreController _003CtargetCtrl_003E__0;

		[Token(Token = "0x400C1E1")]
		[FieldOffset(Offset = "0x24")]
		internal UIDigitaluniverseBGalaxyCanvasController _0024this;

		[Token(Token = "0x400C1E2")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x400C1E3")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x400C1E4")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17000F56")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60095C1")]
			[Address(RVA = "0x2F63C4C", Offset = "0x2F63C4C", VA = "0x2F63C4C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F57")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60095C2")]
			[Address(RVA = "0x2F63C54", Offset = "0x2F63C54", VA = "0x2F63C54", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60095BF")]
		[Address(RVA = "0x2F638C4", Offset = "0x2F638C4", VA = "0x2F638C4")]
		public _003CPlayMoveCoresAnimationExchange_003Ec__Iterator8()
		{
		}

		[Token(Token = "0x60095C0")]
		[Address(RVA = "0x2F638CC", Offset = "0x2F638CC", VA = "0x2F638CC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60095C3")]
		[Address(RVA = "0x2F63C5C", Offset = "0x2F63C5C", VA = "0x2F63C5C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60095C4")]
		[Address(RVA = "0x2F63C70", Offset = "0x2F63C70", VA = "0x2F63C70", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C18C")]
	private const float widthScale = 2.3333333f;

	[Token(Token = "0x400C18D")]
	private const float heightScale = 2.3333333f;

	[Token(Token = "0x400C18E")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, UIDigitaluniverseBCoreController> m_CoreCtrlDic;

	[Token(Token = "0x400C18F")]
	[FieldOffset(Offset = "0x2C")]
	private UIDigitaluniverseBMySelfCoreInfoPanelController m_MySelfPanelCtrl;

	[Token(Token = "0x400C190")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, UIDigitaluniverseBStarLineController> m_LineObjDic;

	[Token(Token = "0x400C191")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400C192")]
	[FieldOffset(Offset = "0x34")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400C193")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_SelfAccountId;

	[Token(Token = "0x400C194")]
	[FieldOffset(Offset = "0x40")]
	private string m_SelfNickName;

	[Token(Token = "0x400C195")]
	private const string STARSPRITENAME0 = "FF_UI_DigitaluniverseB_Starmap_Star00";

	[Token(Token = "0x400C196")]
	private const string STARSPRITENAME1 = "FF_UI_DigitaluniverseB_Starmap_Star01";

	[Token(Token = "0x400C197")]
	private const string STARSPRITENAME2 = "FF_UI_DigitaluniverseB_Starmap_Star02";

	[Token(Token = "0x400C198")]
	private const string STARSPRITENAME3 = "FF_UI_DigitaluniverseB_Starmap_Star03";

	[Token(Token = "0x400C199")]
	private const string STARSPRITENAME4 = "FF_UI_DigitaluniverseB_Starmap_Star04";

	[Token(Token = "0x400C19A")]
	private const string STARSPRITENAME5 = "FF_UI_DigitaluniverseB_Starmap_Star05";

	[Token(Token = "0x400C19B")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsEnlarge;

	[Token(Token = "0x400C19C")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 from;

	[Token(Token = "0x400C19D")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 to;

	[Token(Token = "0x400C19E")]
	[FieldOffset(Offset = "0x60")]
	private UIModelDigitaluniverseB m_DigitaluniverseBModel;

	[Token(Token = "0x400C19F")]
	[FieldOffset(Offset = "0x64")]
	private UIDigitaluniverseBGalaxyCanvasView m_View;

	[Token(Token = "0x6009564")]
	[Address(RVA = "0x2AE2BD8", Offset = "0x2AE2BD8", VA = "0x2AE2BD8")]
	public UIDigitaluniverseBGalaxyCanvasController()
	{
	}

	[Token(Token = "0x6009565")]
	[Address(RVA = "0x2AE2E28", Offset = "0x2AE2E28", VA = "0x2AE2E28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009566")]
	[Address(RVA = "0x2AE2ED0", Offset = "0x2AE2ED0", VA = "0x2AE2ED0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009567")]
	[Address(RVA = "0x2AE3450", Offset = "0x2AE3450", VA = "0x2AE3450", Slot = "33")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6009568")]
	[Address(RVA = "0x2AE3844", Offset = "0x2AE3844", VA = "0x2AE3844", Slot = "34")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6009569")]
	[Address(RVA = "0x2AE3CB8", Offset = "0x2AE3CB8", VA = "0x2AE3CB8")]
	public void OnGesture(List<LeanFinger> fingers)
	{
	}

	[Token(Token = "0x600956A")]
	[Address(RVA = "0x2AE4258", Offset = "0x2AE4258", VA = "0x2AE4258")]
	private void Update()
	{
	}

	[Token(Token = "0x600956B")]
	[Address(RVA = "0x2AE42B8", Offset = "0x2AE42B8", VA = "0x2AE42B8")]
	public void RefreshCanvas()
	{
	}

	[Token(Token = "0x600956C")]
	[Address(RVA = "0x2ADADD8", Offset = "0x2ADADD8", VA = "0x2ADADD8")]
	public void OnBgDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x600956D")]
	[Address(RVA = "0x2AE45A0", Offset = "0x2AE45A0", VA = "0x2AE45A0")]
	public void UpdateViewData()
	{
	}

	[Token(Token = "0x600956E")]
	[Address(RVA = "0x2AE4620", Offset = "0x2AE4620", VA = "0x2AE4620")]
	private void SetCoreStarsViewData()
	{
	}

	[Token(Token = "0x600956F")]
	[Address(RVA = "0x2AE5200", Offset = "0x2AE5200", VA = "0x2AE5200")]
	private void SetLineViewData()
	{
	}

	[Token(Token = "0x6009570")]
	[Address(RVA = "0x2AE5AB8", Offset = "0x2AE5AB8", VA = "0x2AE5AB8")]
	private IEnumerator PlayEnterAnimation()
	{
		return null;
	}

	[Token(Token = "0x6009571")]
	[Address(RVA = "0x2AD9664", Offset = "0x2AD9664", VA = "0x2AD9664")]
	public void AssistBlow(bool isActive)
	{
	}

	[Token(Token = "0x6009572")]
	[Address(RVA = "0x2AE5B84", Offset = "0x2AE5B84", VA = "0x2AE5B84")]
	private void UpdateViewForTrackUpMove(ulong curAccountId, ulong[] before_neighbors, ulong[] after_neighbors)
	{
	}

	[Token(Token = "0x6009573")]
	[Address(RVA = "0x2AE5DD8", Offset = "0x2AE5DD8", VA = "0x2AE5DD8")]
	private void UpdateViewForTrackUpExchange(ulong curAccountId, ulong targetAccountId, ulong[] beforeAccounts, ulong[] afterAccounts)
	{
	}

	[Token(Token = "0x6009574")]
	[Address(RVA = "0x2AE5C94", Offset = "0x2AE5C94", VA = "0x2AE5C94")]
	private IEnumerator PlayMoveAnimation(ulong curAccountId, ulong[] before_neighbors, ulong[] after_neighbors)
	{
		return null;
	}

	[Token(Token = "0x6009575")]
	[Address(RVA = "0x2AE5EFC", Offset = "0x2AE5EFC", VA = "0x2AE5EFC")]
	private IEnumerator PlayExchangeAnimation(ulong curAccountId, ulong targetAccountId, ulong[] beforeAccounts, ulong[] afterAccounts)
	{
		return null;
	}

	[Token(Token = "0x6009576")]
	[Address(RVA = "0x2AE6074", Offset = "0x2AE6074", VA = "0x2AE6074")]
	private IEnumerator PlayDisappearLinesAnimationMove(ulong curAccountId, ulong[] before_neighbors, ulong[] after_neighbors)
	{
		return null;
	}

	[Token(Token = "0x6009577")]
	[Address(RVA = "0x2AE61B4", Offset = "0x2AE61B4", VA = "0x2AE61B4")]
	private IEnumerator PlayDisappearLinesAnimationExchange(ulong curAccountId, ulong targetAccountId, ulong[] beforeAccounts)
	{
		return null;
	}

	[Token(Token = "0x6009578")]
	[Address(RVA = "0x2AE630C", Offset = "0x2AE630C", VA = "0x2AE630C")]
	private void DisappearPreAndNextLine(ulong accountId, ulong pre_accountId, ulong next_accountId = 0uL)
	{
	}

	[Token(Token = "0x6009579")]
	[Address(RVA = "0x2AE64C4", Offset = "0x2AE64C4", VA = "0x2AE64C4")]
	private IEnumerator PlayDrawLineAnimationMove(ulong curAccountId, ulong[] before_neighbors, ulong[] after_neighbors)
	{
		return null;
	}

	[Token(Token = "0x600957A")]
	[Address(RVA = "0x2AE6608", Offset = "0x2AE6608", VA = "0x2AE6608")]
	private IEnumerator PlayDrawLineAnimationExchange(ulong curAccountId, ulong targetAccountId, ulong[] afterAccounts)
	{
		return null;
	}

	[Token(Token = "0x600957B")]
	[Address(RVA = "0x2AE6760", Offset = "0x2AE6760", VA = "0x2AE6760")]
	private void DrawPreLineAndNextLineWithCore(ulong accountId, ulong pre_accountId, ulong next_accountId)
	{
	}

	[Token(Token = "0x600957C")]
	[Address(RVA = "0x2AE6C7C", Offset = "0x2AE6C7C", VA = "0x2AE6C7C")]
	private void DrawPreLineAndNextLineWithOutCore(ulong pre_accountId, ulong next_accountId)
	{
	}

	[Token(Token = "0x600957D")]
	[Address(RVA = "0x2AE6F7C", Offset = "0x2AE6F7C", VA = "0x2AE6F7C")]
	private IEnumerator PlayMoveCoreAnimationMove(ulong curAccountId)
	{
		return null;
	}

	[Token(Token = "0x600957E")]
	[Address(RVA = "0x2AE7088", Offset = "0x2AE7088", VA = "0x2AE7088")]
	private IEnumerator PlayMoveCoresAnimationExchange(ulong curAccountId, ulong targetAccountId)
	{
		return null;
	}

	[Token(Token = "0x600957F")]
	[Address(RVA = "0x2AE71B8", Offset = "0x2AE71B8", VA = "0x2AE71B8")]
	public void SetViewData(bool firstEnter)
	{
	}

	[Token(Token = "0x6009580")]
	[Address(RVA = "0x2AE74EC", Offset = "0x2AE74EC", VA = "0x2AE74EC")]
	private void onMySelfCoreClick()
	{
	}

	[Token(Token = "0x6009581")]
	[Address(RVA = "0x2AE7714", Offset = "0x2AE7714", VA = "0x2AE7714")]
	private void OnAssistLighten()
	{
	}

	[Token(Token = "0x6009582")]
	[Address(RVA = "0x2AE77A4", Offset = "0x2AE77A4", VA = "0x2AE77A4")]
	public void OnCancleCoreSelected(object[] data)
	{
	}

	[Token(Token = "0x6009583")]
	[Address(RVA = "0x2AE791C", Offset = "0x2AE791C", VA = "0x2AE791C")]
	private void SetPosition(Vector3 itemPos)
	{
	}

	[Token(Token = "0x6009584")]
	[Address(RVA = "0x2AE7CD8", Offset = "0x2AE7CD8", VA = "0x2AE7CD8")]
	private void OnPressCoreGuide(object[] data)
	{
	}

	[Token(Token = "0x6009585")]
	[Address(RVA = "0x2AE7D44", Offset = "0x2AE7D44", VA = "0x2AE7D44")]
	private void OnPressCoreGuideFinished(object[] data)
	{
	}

	[Token(Token = "0x6009586")]
	[Address(RVA = "0x2AE7DB0", Offset = "0x2AE7DB0", VA = "0x2AE7DB0")]
	public Transform GetGuideTransform()
	{
		return null;
	}

	[Token(Token = "0x6009587")]
	[Address(RVA = "0x2AE7F68", Offset = "0x2AE7F68", VA = "0x2AE7F68")]
	public UIWidget GetGuideWidget()
	{
		return null;
	}

	[Token(Token = "0x6009588")]
	[Address(RVA = "0x2AE7FD8", Offset = "0x2AE7FD8", VA = "0x2AE7FD8")]
	public void ScaleCanvas(bool isEnlarge)
	{
	}

	[Token(Token = "0x6009589")]
	[Address(RVA = "0x2AE4024", Offset = "0x2AE4024", VA = "0x2AE4024")]
	private void ShowPlayerNames(bool isShow)
	{
	}

	[Token(Token = "0x600958A")]
	[Address(RVA = "0x2ADAB8C", Offset = "0x2ADAB8C", VA = "0x2ADAB8C")]
	public Transform GetSelfCoreAnimationCtrl()
	{
		return null;
	}

	[Token(Token = "0x600958B")]
	[Address(RVA = "0x2AE836C", Offset = "0x2AE836C", VA = "0x2AE836C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600958C")]
	[Address(RVA = "0x2AE8964", Offset = "0x2AE8964", VA = "0x2AE8964", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600958D")]
	[Address(RVA = "0x2AE33B8", Offset = "0x2AE33B8", VA = "0x2AE33B8")]
	public void SetDragEnable(bool isshow)
	{
	}

	[Token(Token = "0x600958E")]
	[Address(RVA = "0x2AE89F8", Offset = "0x2AE89F8", VA = "0x2AE89F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
