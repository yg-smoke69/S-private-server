using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

[Token(Token = "0x2003DB7")]
public static class AkBankManager
{
	[Token(Token = "0x2003DB8")]
	private class BankHandle
	{
		[Token(Token = "0x401A384")]
		[FieldOffset(Offset = "0x8")]
		protected readonly string bankName;

		[Token(Token = "0x401A385")]
		[FieldOffset(Offset = "0xC")]
		protected uint m_BankID;

		[Token(Token = "0x401A386")]
		[FieldOffset(Offset = "0x10")]
		private int _003CRefCount_003Ek__BackingField;

		[Token(Token = "0x17001B19")]
		public int RefCount
		{
			[Token(Token = "0x6019230")]
			[Address(RVA = "0x35C7EBC", Offset = "0x35C7EBC", VA = "0x35C7EBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6019231")]
			[Address(RVA = "0x35C898C", Offset = "0x35C898C", VA = "0x35C898C")]
			private set
			{
			}
		}

		[Token(Token = "0x601922F")]
		[Address(RVA = "0x35C7C28", Offset = "0x35C7C28", VA = "0x35C7C28")]
		public BankHandle(string name)
		{
		}

		[Token(Token = "0x6019232")]
		[Address(RVA = "0x35C8994", Offset = "0x35C8994", VA = "0x35C8994", Slot = "4")]
		public virtual AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[Token(Token = "0x6019233")]
		[Address(RVA = "0x35C7C48", Offset = "0x35C7C48", VA = "0x35C7C48")]
		public void LoadBank()
		{
		}

		[Token(Token = "0x6019234")]
		[Address(RVA = "0x35C8A28", Offset = "0x35C8A28", VA = "0x35C8A28", Slot = "5")]
		public virtual void UnloadBank()
		{
		}

		[Token(Token = "0x6019235")]
		[Address(RVA = "0x35C7DB8", Offset = "0x35C7DB8", VA = "0x35C7DB8")]
		public void IncRef()
		{
		}

		[Token(Token = "0x6019236")]
		[Address(RVA = "0x35C7DF0", Offset = "0x35C7DF0", VA = "0x35C7DF0")]
		public void DecRef()
		{
		}

		[Token(Token = "0x6019237")]
		[Address(RVA = "0x35C8238", Offset = "0x35C8238", VA = "0x35C8238")]
		protected void LogLoadResult(AKRESULT result)
		{
		}
	}

	[Token(Token = "0x2003DB9")]
	private class AsyncBankHandle : BankHandle
	{
		[Token(Token = "0x401A387")]
		[FieldOffset(Offset = "0x14")]
		private readonly AkCallbackManager.BankCallback bankCallback;

		[Token(Token = "0x401A388")]
		[FieldOffset(Offset = "0x0")]
		private static AkCallbackManager.BankCallback _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x6019238")]
		[Address(RVA = "0x35C7DC8", Offset = "0x35C7DC8", VA = "0x35C7DC8")]
		public AsyncBankHandle(string name, AkCallbackManager.BankCallback callback)
		{
		}

		[Token(Token = "0x6019239")]
		[Address(RVA = "0x35C7FBC", Offset = "0x35C7FBC", VA = "0x35C7FBC")]
		private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie)
		{
		}

		[Token(Token = "0x601923A")]
		[Address(RVA = "0x35C8854", Offset = "0x35C8854", VA = "0x35C8854", Slot = "4")]
		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}
	}

	[Token(Token = "0x2003DBA")]
	private class DecodableBankHandle : BankHandle
	{
		[Token(Token = "0x401A389")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool decodeBank;

		[Token(Token = "0x401A38A")]
		[FieldOffset(Offset = "0x18")]
		private readonly string decodedBankPath;

		[Token(Token = "0x401A38B")]
		[FieldOffset(Offset = "0x1C")]
		private readonly bool saveDecodedBank;

		[Token(Token = "0x601923B")]
		[Address(RVA = "0x35C78D4", Offset = "0x35C78D4", VA = "0x35C78D4")]
		public DecodableBankHandle(string name, bool save)
		{
		}

		[Token(Token = "0x601923C")]
		[Address(RVA = "0x35C8C28", Offset = "0x35C8C28", VA = "0x35C8C28", Slot = "4")]
		public override AKRESULT DoLoadBank()
		{
			return default(AKRESULT);
		}

		[Token(Token = "0x601923D")]
		[Address(RVA = "0x35C8E64", Offset = "0x35C8E64", VA = "0x35C8E64", Slot = "5")]
		public override void UnloadBank()
		{
		}
	}

	[Token(Token = "0x401A381")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, BankHandle> m_BankHandles;

	[Token(Token = "0x401A382")]
	[FieldOffset(Offset = "0x4")]
	private static readonly List<BankHandle> BanksToUnload;

	[Token(Token = "0x401A383")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Mutex m_Mutex;

	[Token(Token = "0x6019227")]
	[Address(RVA = "0x35C73E8", Offset = "0x35C73E8", VA = "0x35C73E8")]
	internal static void DoUnloadBanks()
	{
	}

	[Token(Token = "0x6019228")]
	[Address(RVA = "0x35C75C0", Offset = "0x35C75C0", VA = "0x35C75C0")]
	internal static void Reset()
	{
	}

	[Token(Token = "0x6019229")]
	[Address(RVA = "0x35C76B4", Offset = "0x35C76B4", VA = "0x35C76B4")]
	public static void LoadInitBank(bool doReset = true)
	{
	}

	[Token(Token = "0x601922A")]
	[Address(RVA = "0x35C7844", Offset = "0x35C7844", VA = "0x35C7844")]
	public static void UnloadInitBank()
	{
	}

	[Token(Token = "0x601922B")]
	[Address(RVA = "0x35BC074", Offset = "0x35BC074", VA = "0x35BC074")]
	public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank)
	{
	}

	[Token(Token = "0x601922C")]
	[Address(RVA = "0x35BC3F8", Offset = "0x35BC3F8", VA = "0x35BC3F8")]
	public static void LoadBankAsync(string name, [Optional] AkCallbackManager.BankCallback callback)
	{
	}

	[Token(Token = "0x601922D")]
	[Address(RVA = "0x35BC738", Offset = "0x35BC738", VA = "0x35BC738")]
	public static void UnloadBank(string name)
	{
	}
}
