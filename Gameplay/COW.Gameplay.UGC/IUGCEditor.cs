using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C35")]
public interface IUGCEditor<T>
{
	[Token(Token = "0x6005D2B")]
	bool LoadProject(byte[] projectDataBytes, [Optional] EditorEntityData editorEntityData);

	[Token(Token = "0x6005D2C")]
	bool UnloadProject();

	[Token(Token = "0x6005D2D")]
	bool Export(out byte[] projectDataBytes, out T runtimeData, ref EditorMiscData miscData);
}
