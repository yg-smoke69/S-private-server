using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D81")]
public class AkMIDIEvent : _Attribute
{
	[Token(Token = "0x2003D82")]
	public class tGen : _Attribute
	{
		[Token(Token = "0x401A25E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A25F")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001A97")]
		public byte byParam1
		{
			[Token(Token = "0x6019018")]
			[Address(RVA = "0x36B5510", Offset = "0x36B5510", VA = "0x36B5510")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019017")]
			[Address(RVA = "0x36B5480", Offset = "0x36B5480", VA = "0x36B5480")]
			set
			{
			}
		}

		[Token(Token = "0x17001A98")]
		public byte byParam2
		{
			[Token(Token = "0x601901A")]
			[Address(RVA = "0x36B5628", Offset = "0x36B5628", VA = "0x36B5628")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019019")]
			[Address(RVA = "0x36B5598", Offset = "0x36B5598", VA = "0x36B5598")]
			set
			{
			}
		}

		[Token(Token = "0x6019011")]
		[Address(RVA = "0x36B30C8", Offset = "0x36B30C8", VA = "0x36B30C8")]
		internal tGen(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6019012")]
		[Address(RVA = "0x36B5218", Offset = "0x36B5218", VA = "0x36B5218")]
		public tGen()
		{
		}

		[Token(Token = "0x6019013")]
		[Address(RVA = "0x36B2F9C", Offset = "0x36B2F9C", VA = "0x36B2F9C")]
		internal static IntPtr getCPtr(tGen obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6019014")]
		[Address(RVA = "0x36B52B4", Offset = "0x36B52B4", VA = "0x36B52B4", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x6019015")]
		[Address(RVA = "0x36B52E0", Offset = "0x36B52E0", VA = "0x36B52E0", Slot = "1")]
		~tGen()
		{
		}

		[Token(Token = "0x6019016")]
		[Address(RVA = "0x36B5354", Offset = "0x36B5354", VA = "0x36B5354", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D83")]
	public class tNoteOnOff : _Attribute
	{
		[Token(Token = "0x401A260")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A261")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001A99")]
		public byte byNote
		{
			[Token(Token = "0x6019022")]
			[Address(RVA = "0x36B5E40", Offset = "0x36B5E40", VA = "0x36B5E40")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019021")]
			[Address(RVA = "0x36B5DB0", Offset = "0x36B5DB0", VA = "0x36B5DB0")]
			set
			{
			}
		}

		[Token(Token = "0x17001A9A")]
		public byte byVelocity
		{
			[Token(Token = "0x6019024")]
			[Address(RVA = "0x36B5F58", Offset = "0x36B5F58", VA = "0x36B5F58")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019023")]
			[Address(RVA = "0x36B5EC8", Offset = "0x36B5EC8", VA = "0x36B5EC8")]
			set
			{
			}
		}

		[Token(Token = "0x601901B")]
		[Address(RVA = "0x36B3520", Offset = "0x36B3520", VA = "0x36B3520")]
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x601901C")]
		[Address(RVA = "0x36B5B48", Offset = "0x36B5B48", VA = "0x36B5B48")]
		public tNoteOnOff()
		{
		}

		[Token(Token = "0x601901D")]
		[Address(RVA = "0x36B33F4", Offset = "0x36B33F4", VA = "0x36B33F4")]
		internal static IntPtr getCPtr(tNoteOnOff obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x601901E")]
		[Address(RVA = "0x36B5BE4", Offset = "0x36B5BE4", VA = "0x36B5BE4", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x601901F")]
		[Address(RVA = "0x36B5C10", Offset = "0x36B5C10", VA = "0x36B5C10", Slot = "1")]
		~tNoteOnOff()
		{
		}

		[Token(Token = "0x6019020")]
		[Address(RVA = "0x36B5C84", Offset = "0x36B5C84", VA = "0x36B5C84", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D84")]
	public class tCc : _Attribute
	{
		[Token(Token = "0x401A262")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A263")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001A9B")]
		public byte byCc
		{
			[Token(Token = "0x601902C")]
			[Address(RVA = "0x36B4CF8", Offset = "0x36B4CF8", VA = "0x36B4CF8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x601902B")]
			[Address(RVA = "0x36B4C68", Offset = "0x36B4C68", VA = "0x36B4C68")]
			set
			{
			}
		}

		[Token(Token = "0x17001A9C")]
		public byte byValue
		{
			[Token(Token = "0x601902E")]
			[Address(RVA = "0x36B4E10", Offset = "0x36B4E10", VA = "0x36B4E10")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x601902D")]
			[Address(RVA = "0x36B4D80", Offset = "0x36B4D80", VA = "0x36B4D80")]
			set
			{
			}
		}

		[Token(Token = "0x6019025")]
		[Address(RVA = "0x36B32F4", Offset = "0x36B32F4", VA = "0x36B32F4")]
		internal tCc(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6019026")]
		[Address(RVA = "0x36B4A00", Offset = "0x36B4A00", VA = "0x36B4A00")]
		public tCc()
		{
		}

		[Token(Token = "0x6019027")]
		[Address(RVA = "0x36B31C8", Offset = "0x36B31C8", VA = "0x36B31C8")]
		internal static IntPtr getCPtr(tCc obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6019028")]
		[Address(RVA = "0x36B4A9C", Offset = "0x36B4A9C", VA = "0x36B4A9C", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x6019029")]
		[Address(RVA = "0x36B4AC8", Offset = "0x36B4AC8", VA = "0x36B4AC8", Slot = "1")]
		~tCc()
		{
		}

		[Token(Token = "0x601902A")]
		[Address(RVA = "0x36B4B3C", Offset = "0x36B4B3C", VA = "0x36B4B3C", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D85")]
	public class tPitchBend : _Attribute
	{
		[Token(Token = "0x401A264")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A265")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001A9D")]
		public byte byValueLsb
		{
			[Token(Token = "0x6019036")]
			[Address(RVA = "0x36B62D8", Offset = "0x36B62D8", VA = "0x36B62D8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019035")]
			[Address(RVA = "0x36B6248", Offset = "0x36B6248", VA = "0x36B6248")]
			set
			{
			}
		}

		[Token(Token = "0x17001A9E")]
		public byte byValueMsb
		{
			[Token(Token = "0x6019038")]
			[Address(RVA = "0x36B63F0", Offset = "0x36B63F0", VA = "0x36B63F0")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019037")]
			[Address(RVA = "0x36B6360", Offset = "0x36B6360", VA = "0x36B6360")]
			set
			{
			}
		}

		[Token(Token = "0x601902F")]
		[Address(RVA = "0x36B374C", Offset = "0x36B374C", VA = "0x36B374C")]
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6019030")]
		[Address(RVA = "0x36B5FE0", Offset = "0x36B5FE0", VA = "0x36B5FE0")]
		public tPitchBend()
		{
		}

		[Token(Token = "0x6019031")]
		[Address(RVA = "0x36B3620", Offset = "0x36B3620", VA = "0x36B3620")]
		internal static IntPtr getCPtr(tPitchBend obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6019032")]
		[Address(RVA = "0x36B607C", Offset = "0x36B607C", VA = "0x36B607C", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x6019033")]
		[Address(RVA = "0x36B60A8", Offset = "0x36B60A8", VA = "0x36B60A8", Slot = "1")]
		~tPitchBend()
		{
		}

		[Token(Token = "0x6019034")]
		[Address(RVA = "0x36B611C", Offset = "0x36B611C", VA = "0x36B611C", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D86")]
	public class tNoteAftertouch : _Attribute
	{
		[Token(Token = "0x401A266")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A267")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001A9F")]
		public byte byNote
		{
			[Token(Token = "0x6019040")]
			[Address(RVA = "0x36B59A8", Offset = "0x36B59A8", VA = "0x36B59A8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x601903F")]
			[Address(RVA = "0x36B5918", Offset = "0x36B5918", VA = "0x36B5918")]
			set
			{
			}
		}

		[Token(Token = "0x17001AA0")]
		public byte byValue
		{
			[Token(Token = "0x6019042")]
			[Address(RVA = "0x36B5AC0", Offset = "0x36B5AC0", VA = "0x36B5AC0")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019041")]
			[Address(RVA = "0x36B5A30", Offset = "0x36B5A30", VA = "0x36B5A30")]
			set
			{
			}
		}

		[Token(Token = "0x6019039")]
		[Address(RVA = "0x36B3978", Offset = "0x36B3978", VA = "0x36B3978")]
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x601903A")]
		[Address(RVA = "0x36B56B0", Offset = "0x36B56B0", VA = "0x36B56B0")]
		public tNoteAftertouch()
		{
		}

		[Token(Token = "0x601903B")]
		[Address(RVA = "0x36B384C", Offset = "0x36B384C", VA = "0x36B384C")]
		internal static IntPtr getCPtr(tNoteAftertouch obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x601903C")]
		[Address(RVA = "0x36B574C", Offset = "0x36B574C", VA = "0x36B574C", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x601903D")]
		[Address(RVA = "0x36B5778", Offset = "0x36B5778", VA = "0x36B5778", Slot = "1")]
		~tNoteAftertouch()
		{
		}

		[Token(Token = "0x601903E")]
		[Address(RVA = "0x36B57EC", Offset = "0x36B57EC", VA = "0x36B57EC", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D87")]
	public class tChanAftertouch : _Attribute
	{
		[Token(Token = "0x401A268")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A269")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001AA1")]
		public byte byValue
		{
			[Token(Token = "0x601904A")]
			[Address(RVA = "0x36B5190", Offset = "0x36B5190", VA = "0x36B5190")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019049")]
			[Address(RVA = "0x36B5100", Offset = "0x36B5100", VA = "0x36B5100")]
			set
			{
			}
		}

		[Token(Token = "0x6019043")]
		[Address(RVA = "0x36B3BA4", Offset = "0x36B3BA4", VA = "0x36B3BA4")]
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6019044")]
		[Address(RVA = "0x36B4E98", Offset = "0x36B4E98", VA = "0x36B4E98")]
		public tChanAftertouch()
		{
		}

		[Token(Token = "0x6019045")]
		[Address(RVA = "0x36B3A78", Offset = "0x36B3A78", VA = "0x36B3A78")]
		internal static IntPtr getCPtr(tChanAftertouch obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6019046")]
		[Address(RVA = "0x36B4F34", Offset = "0x36B4F34", VA = "0x36B4F34", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x6019047")]
		[Address(RVA = "0x36B4F60", Offset = "0x36B4F60", VA = "0x36B4F60", Slot = "1")]
		~tChanAftertouch()
		{
		}

		[Token(Token = "0x6019048")]
		[Address(RVA = "0x36B4FD4", Offset = "0x36B4FD4", VA = "0x36B4FD4", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x2003D88")]
	public class tProgramChange : _Attribute
	{
		[Token(Token = "0x401A26A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr swigCPtr;

		[Token(Token = "0x401A26B")]
		[FieldOffset(Offset = "0xC")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17001AA2")]
		public byte byProgramNum
		{
			[Token(Token = "0x6019052")]
			[Address(RVA = "0x36B6770", Offset = "0x36B6770", VA = "0x36B6770")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6019051")]
			[Address(RVA = "0x36B66E0", Offset = "0x36B66E0", VA = "0x36B66E0")]
			set
			{
			}
		}

		[Token(Token = "0x601904B")]
		[Address(RVA = "0x36B3DD0", Offset = "0x36B3DD0", VA = "0x36B3DD0")]
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x601904C")]
		[Address(RVA = "0x36B6478", Offset = "0x36B6478", VA = "0x36B6478")]
		public tProgramChange()
		{
		}

		[Token(Token = "0x601904D")]
		[Address(RVA = "0x36B3CA4", Offset = "0x36B3CA4", VA = "0x36B3CA4")]
		internal static IntPtr getCPtr(tProgramChange obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x601904E")]
		[Address(RVA = "0x36B6514", Offset = "0x36B6514", VA = "0x36B6514", Slot = "5")]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[Token(Token = "0x601904F")]
		[Address(RVA = "0x36B6540", Offset = "0x36B6540", VA = "0x36B6540", Slot = "1")]
		~tProgramChange()
		{
		}

		[Token(Token = "0x6019050")]
		[Address(RVA = "0x36B65B4", Offset = "0x36B65B4", VA = "0x36B65B4", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}

	[Token(Token = "0x401A25C")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A25D")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A84")]
	public byte byChan
	{
		[Token(Token = "0x6018FEC")]
		[Address(RVA = "0x36B2E3C", Offset = "0x36B2E3C", VA = "0x36B2E3C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018FEB")]
		[Address(RVA = "0x36B2DAC", Offset = "0x36B2DAC", VA = "0x36B2DAC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A85")]
	public tGen Gen
	{
		[Token(Token = "0x6018FEE")]
		[Address(RVA = "0x36B2FF4", Offset = "0x36B2FF4", VA = "0x36B2FF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FED")]
		[Address(RVA = "0x36B2EC4", Offset = "0x36B2EC4", VA = "0x36B2EC4")]
		set
		{
		}
	}

	[Token(Token = "0x17001A86")]
	public tCc Cc
	{
		[Token(Token = "0x6018FF0")]
		[Address(RVA = "0x36B3220", Offset = "0x36B3220", VA = "0x36B3220")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FEF")]
		[Address(RVA = "0x36B30F0", Offset = "0x36B30F0", VA = "0x36B30F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A87")]
	public tNoteOnOff NoteOnOff
	{
		[Token(Token = "0x6018FF2")]
		[Address(RVA = "0x36B344C", Offset = "0x36B344C", VA = "0x36B344C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FF1")]
		[Address(RVA = "0x36B331C", Offset = "0x36B331C", VA = "0x36B331C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A88")]
	public tPitchBend PitchBend
	{
		[Token(Token = "0x6018FF4")]
		[Address(RVA = "0x36B3678", Offset = "0x36B3678", VA = "0x36B3678")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FF3")]
		[Address(RVA = "0x36B3548", Offset = "0x36B3548", VA = "0x36B3548")]
		set
		{
		}
	}

	[Token(Token = "0x17001A89")]
	public tNoteAftertouch NoteAftertouch
	{
		[Token(Token = "0x6018FF6")]
		[Address(RVA = "0x36B38A4", Offset = "0x36B38A4", VA = "0x36B38A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FF5")]
		[Address(RVA = "0x36B3774", Offset = "0x36B3774", VA = "0x36B3774")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8A")]
	public tChanAftertouch ChanAftertouch
	{
		[Token(Token = "0x6018FF8")]
		[Address(RVA = "0x36B3AD0", Offset = "0x36B3AD0", VA = "0x36B3AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FF7")]
		[Address(RVA = "0x36B39A0", Offset = "0x36B39A0", VA = "0x36B39A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8B")]
	public tProgramChange ProgramChange
	{
		[Token(Token = "0x6018FFA")]
		[Address(RVA = "0x36B3CFC", Offset = "0x36B3CFC", VA = "0x36B3CFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FF9")]
		[Address(RVA = "0x36B3BCC", Offset = "0x36B3BCC", VA = "0x36B3BCC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8C")]
	public AkMIDIEventTypes byType
	{
		[Token(Token = "0x6018FFC")]
		[Address(RVA = "0x36B3E88", Offset = "0x36B3E88", VA = "0x36B3E88")]
		get
		{
			return default(AkMIDIEventTypes);
		}
		[Token(Token = "0x6018FFB")]
		[Address(RVA = "0x36B3DF8", Offset = "0x36B3DF8", VA = "0x36B3DF8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8D")]
	public byte byOnOffNote
	{
		[Token(Token = "0x6018FFE")]
		[Address(RVA = "0x36B3FA0", Offset = "0x36B3FA0", VA = "0x36B3FA0")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018FFD")]
		[Address(RVA = "0x36B3F10", Offset = "0x36B3F10", VA = "0x36B3F10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8E")]
	public byte byVelocity
	{
		[Token(Token = "0x6019000")]
		[Address(RVA = "0x36B40B8", Offset = "0x36B40B8", VA = "0x36B40B8")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018FFF")]
		[Address(RVA = "0x36B4028", Offset = "0x36B4028", VA = "0x36B4028")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8F")]
	public AkMIDICcTypes byCc
	{
		[Token(Token = "0x6019002")]
		[Address(RVA = "0x36B41D0", Offset = "0x36B41D0", VA = "0x36B41D0")]
		get
		{
			return default(AkMIDICcTypes);
		}
		[Token(Token = "0x6019001")]
		[Address(RVA = "0x36B4140", Offset = "0x36B4140", VA = "0x36B4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001A90")]
	public byte byCcValue
	{
		[Token(Token = "0x6019004")]
		[Address(RVA = "0x36B42E8", Offset = "0x36B42E8", VA = "0x36B42E8")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6019003")]
		[Address(RVA = "0x36B4258", Offset = "0x36B4258", VA = "0x36B4258")]
		set
		{
		}
	}

	[Token(Token = "0x17001A91")]
	public byte byValueLsb
	{
		[Token(Token = "0x6019006")]
		[Address(RVA = "0x36B4400", Offset = "0x36B4400", VA = "0x36B4400")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6019005")]
		[Address(RVA = "0x36B4370", Offset = "0x36B4370", VA = "0x36B4370")]
		set
		{
		}
	}

	[Token(Token = "0x17001A92")]
	public byte byValueMsb
	{
		[Token(Token = "0x6019008")]
		[Address(RVA = "0x36B4518", Offset = "0x36B4518", VA = "0x36B4518")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6019007")]
		[Address(RVA = "0x36B4488", Offset = "0x36B4488", VA = "0x36B4488")]
		set
		{
		}
	}

	[Token(Token = "0x17001A93")]
	public byte byAftertouchNote
	{
		[Token(Token = "0x601900A")]
		[Address(RVA = "0x36B4630", Offset = "0x36B4630", VA = "0x36B4630")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6019009")]
		[Address(RVA = "0x36B45A0", Offset = "0x36B45A0", VA = "0x36B45A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A94")]
	public byte byNoteAftertouchValue
	{
		[Token(Token = "0x601900C")]
		[Address(RVA = "0x36B4748", Offset = "0x36B4748", VA = "0x36B4748")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x601900B")]
		[Address(RVA = "0x36B46B8", Offset = "0x36B46B8", VA = "0x36B46B8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A95")]
	public byte byChanAftertouchValue
	{
		[Token(Token = "0x601900E")]
		[Address(RVA = "0x36B4860", Offset = "0x36B4860", VA = "0x36B4860")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x601900D")]
		[Address(RVA = "0x36B47D0", Offset = "0x36B47D0", VA = "0x36B47D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A96")]
	public byte byProgramNum
	{
		[Token(Token = "0x6019010")]
		[Address(RVA = "0x36B4978", Offset = "0x36B4978", VA = "0x36B4978")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x601900F")]
		[Address(RVA = "0x36B48E8", Offset = "0x36B48E8", VA = "0x36B48E8")]
		set
		{
		}
	}

	[Token(Token = "0x6018FE5")]
	[Address(RVA = "0x36B2AC4", Offset = "0x36B2AC4", VA = "0x36B2AC4")]
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018FE6")]
	[Address(RVA = "0x36B2AEC", Offset = "0x36B2AEC", VA = "0x36B2AEC")]
	public AkMIDIEvent()
	{
	}

	[Token(Token = "0x6018FE7")]
	[Address(RVA = "0x36B2B88", Offset = "0x36B2B88", VA = "0x36B2B88")]
	internal static IntPtr getCPtr(AkMIDIEvent obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018FE8")]
	[Address(RVA = "0x36B2BE0", Offset = "0x36B2BE0", VA = "0x36B2BE0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018FE9")]
	[Address(RVA = "0x36B2C0C", Offset = "0x36B2C0C", VA = "0x36B2C0C", Slot = "1")]
	~AkMIDIEvent()
	{
	}

	[Token(Token = "0x6018FEA")]
	[Address(RVA = "0x36B2C80", Offset = "0x36B2C80", VA = "0x36B2C80", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
