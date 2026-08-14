using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003D27")]
public class SceneStreamerInfoHelper
{
	[Token(Token = "0x4019EFE")]
	[FieldOffset(Offset = "0x0")]
	private static SceneStreamerInfoHelper m_Instance;

	[Token(Token = "0x4019EFF")]
	[FieldOffset(Offset = "0x8")]
	public bool m_HaveUnloaded;

	[Token(Token = "0x4019F00")]
	[FieldOffset(Offset = "0x9")]
	public bool EnableMeshUnload;

	[Token(Token = "0x4019F01")]
	[FieldOffset(Offset = "0xA")]
	public bool EnableTextureUnload;

	[Token(Token = "0x4019F02")]
	[FieldOffset(Offset = "0xB")]
	private bool m_IsInited;

	[Token(Token = "0x4019F03")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, StreamerMeshInfo> m_MeshInfos;

	[Token(Token = "0x4019F04")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, StreamerTextureInfo> m_TexureInfos;

	[Token(Token = "0x4019F05")]
	[FieldOffset(Offset = "0x14")]
	private List<StreamerObjectRefInfo> m_NeedUnloadInfos;

	[Token(Token = "0x170019E3")]
	public static SceneStreamerInfoHelper Instance
	{
		[Token(Token = "0x6018782")]
		[Address(RVA = "0x21C4488", Offset = "0x21C4488", VA = "0x21C4488")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018781")]
	[Address(RVA = "0x21C4BD4", Offset = "0x21C4BD4", VA = "0x21C4BD4")]
	public SceneStreamerInfoHelper()
	{
	}

	[Token(Token = "0x6018783")]
	[Address(RVA = "0x21C4BE4", Offset = "0x21C4BE4", VA = "0x21C4BE4")]
	public static SceneStreamerInfoHelper CreateInstance(bool enable_mesh_unload, bool enbale_texture_unlaod)
	{
		return null;
	}

	[Token(Token = "0x6018784")]
	[Address(RVA = "0x21C4DD0", Offset = "0x21C4DD0", VA = "0x21C4DD0")]
	public static void ClearInstance()
	{
	}

	[Token(Token = "0x6018785")]
	[Address(RVA = "0x21C4CD0", Offset = "0x21C4CD0", VA = "0x21C4CD0")]
	public void Init(bool enable_mesh_unload, bool enbale_texture_unlaod)
	{
	}

	[Token(Token = "0x6018786")]
	[Address(RVA = "0x21C4E58", Offset = "0x21C4E58", VA = "0x21C4E58")]
	public void UnInit()
	{
	}

	[Token(Token = "0x6018787")]
	[Address(RVA = "0x21C4F1C", Offset = "0x21C4F1C", VA = "0x21C4F1C")]
	public void UpdateObjectRefs(StreamerSceneCollectionInfo scene_streamer_info)
	{
	}

	[Token(Token = "0x6018788")]
	[Address(RVA = "0x21C4504", Offset = "0x21C4504", VA = "0x21C4504")]
	public StreamerMeshInfo FindMeshInfo(uint _mesh_id, bool could_create = false)
	{
		return null;
	}

	[Token(Token = "0x6018789")]
	[Address(RVA = "0x21C4658", Offset = "0x21C4658", VA = "0x21C4658")]
	public StreamerTextureInfo FindTextureInfo(uint _text_id, bool could_create = false)
	{
		return null;
	}

	[Token(Token = "0x601878A")]
	[Address(RVA = "0x21C5238", Offset = "0x21C5238", VA = "0x21C5238")]
	public void RemoveMeshInfo(uint _mesh_id)
	{
	}

	[Token(Token = "0x601878B")]
	[Address(RVA = "0x21C52B8", Offset = "0x21C52B8", VA = "0x21C52B8")]
	public void RemoveTexureInfo(uint _texture_id)
	{
	}

	[Token(Token = "0x601878C")]
	[Address(RVA = "0x21C5338", Offset = "0x21C5338", VA = "0x21C5338")]
	public void RecordNeedUnloadObject(StreamerObjectRefInfo ref_info)
	{
	}

	[Token(Token = "0x601878D")]
	[Address(RVA = "0x21C53B8", Offset = "0x21C53B8", VA = "0x21C53B8")]
	public void UnloadUnusedAssets()
	{
	}
}
