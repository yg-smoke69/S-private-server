using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003ACB")]
public class TaskDragDrop : BaseTask
{
	[Token(Token = "0x4018FB3")]
	[FieldOffset(Offset = "0x48")]
	public TaskDragDropContainer[] dragDropContainers;

	[Token(Token = "0x4018FB4")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsComplete;

	[Token(Token = "0x4018FB5")]
	[FieldOffset(Offset = "0x0")]
	private static Func<TaskDragDropContainer, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6017483")]
	[Address(RVA = "0x28966A8", Offset = "0x28966A8", VA = "0x28966A8")]
	public TaskDragDrop()
	{
	}

	[Token(Token = "0x6017484")]
	[Address(RVA = "0x28966B0", Offset = "0x28966B0", VA = "0x28966B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017485")]
	[Address(RVA = "0x289671C", Offset = "0x289671C", VA = "0x289671C", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017486")]
	[Address(RVA = "0x2896794", Offset = "0x2896794", VA = "0x2896794")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x6017487")]
	[Address(RVA = "0x28968F4", Offset = "0x28968F4", VA = "0x28968F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6017488")]
	[Address(RVA = "0x2896960", Offset = "0x2896960", VA = "0x2896960")]
	private static bool _003CCheckComplete_003Em__0(TaskDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x6017489")]
	[Address(RVA = "0x2896998", Offset = "0x2896998", VA = "0x2896998")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
