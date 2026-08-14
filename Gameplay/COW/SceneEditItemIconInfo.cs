using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DC0")]
public class SceneEditItemIconInfo
{
	[Token(Token = "0x4011901")]
	[FieldOffset(Offset = "0x8")]
	private List<SceneEditItemIcon> _003Cinfos_003Ek__BackingField;

	[Token(Token = "0x170013E5")]
	public List<SceneEditItemIcon> infos
	{
		[Token(Token = "0x60132F4")]
		[Address(RVA = "0x241F538", Offset = "0x241F538", VA = "0x241F538")]
		get
		{
			return null;
		}
		[Token(Token = "0x60132F5")]
		[Address(RVA = "0x241F530", Offset = "0x241F530", VA = "0x241F530")]
		private set
		{
		}
	}

	[Token(Token = "0x60132F3")]
	[Address(RVA = "0x241F4A4", Offset = "0x241F4A4", VA = "0x241F4A4")]
	public SceneEditItemIconInfo()
	{
	}
}
