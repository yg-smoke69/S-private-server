using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E7A")]
public class CommandManager
{
	[Token(Token = "0x2003E7B")]
	internal class RingStack<T>
	{
		[Token(Token = "0x401A6A4")]
		[FieldOffset(Offset = "0x0")]
		protected T[] m_Datas;

		[Token(Token = "0x401A6A5")]
		[FieldOffset(Offset = "0x0")]
		protected int m_Capacity;

		[Token(Token = "0x401A6A6")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_AllowOverflow;

		[Token(Token = "0x401A6A7")]
		[FieldOffset(Offset = "0x0")]
		protected int m_Size;

		[Token(Token = "0x401A6A8")]
		[FieldOffset(Offset = "0x0")]
		protected int m_Head;

		[Token(Token = "0x401A6A9")]
		[FieldOffset(Offset = "0x0")]
		protected int m_Tail;

		[Token(Token = "0x17001BBB")]
		public int Count
		{
			[Token(Token = "0x60196EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17001BBC")]
		public bool AllowOverflow
		{
			[Token(Token = "0x60196ED")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60196EB")]
		public RingStack(int capacity, bool allowOverflow)
		{
		}

		[Token(Token = "0x60196EE")]
		public T Pop()
		{
			return (T)null;
		}

		[Token(Token = "0x60196EF")]
		public void Push(T item)
		{
		}

		[Token(Token = "0x60196F0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60196F1")]
		protected void Add(T item, bool overflow)
		{
		}
	}

	[Token(Token = "0x401A6A2")]
	[FieldOffset(Offset = "0x8")]
	private readonly RingStack<Command> m_ExecuteStack;

	[Token(Token = "0x401A6A3")]
	[FieldOffset(Offset = "0xC")]
	private readonly RingStack<Command> m_UnExecuteStack;

	[Token(Token = "0x60196E5")]
	[Address(RVA = "0x308660C", Offset = "0x308660C", VA = "0x308660C")]
	public CommandManager(int cacheCount)
	{
	}

	[Token(Token = "0x60196E6")]
	[Address(RVA = "0x30866C4", Offset = "0x30866C4", VA = "0x30866C4")]
	public void ExecuteCommand(Command command)
	{
	}

	[Token(Token = "0x60196E7")]
	[Address(RVA = "0x3086A60", Offset = "0x3086A60", VA = "0x3086A60")]
	public void Clear()
	{
	}

	[Token(Token = "0x60196E8")]
	[Address(RVA = "0x3086A80", Offset = "0x3086A80", VA = "0x3086A80")]
	public void Undo()
	{
	}

	[Token(Token = "0x60196E9")]
	[Address(RVA = "0x3086B80", Offset = "0x3086B80", VA = "0x3086B80")]
	public void Redo()
	{
	}

	[Token(Token = "0x60196EA")]
	[Address(RVA = "0x30867E4", Offset = "0x30867E4", VA = "0x30867E4")]
	private void ClearStack(RingStack<Command> stack)
	{
	}
}
