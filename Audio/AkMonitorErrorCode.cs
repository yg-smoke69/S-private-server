using Il2CppDummyDll;

[Token(Token = "0x2003D8C")]
public enum AkMonitorErrorCode
{
	[Token(Token = "0x401A27A")]
	ErrorCode_NoError,
	[Token(Token = "0x401A27B")]
	ErrorCode_FileNotFound,
	[Token(Token = "0x401A27C")]
	ErrorCode_CannotOpenFile,
	[Token(Token = "0x401A27D")]
	ErrorCode_CannotStartStreamNoMemory,
	[Token(Token = "0x401A27E")]
	ErrorCode_IODevice,
	[Token(Token = "0x401A27F")]
	ErrorCode_IncompatibleIOSettings,
	[Token(Token = "0x401A280")]
	ErrorCode_PluginUnsupportedChannelConfiguration,
	[Token(Token = "0x401A281")]
	ErrorCode_PluginMediaUnavailable,
	[Token(Token = "0x401A282")]
	ErrorCode_PluginInitialisationFailed,
	[Token(Token = "0x401A283")]
	ErrorCode_PluginProcessingFailed,
	[Token(Token = "0x401A284")]
	ErrorCode_PluginExecutionInvalid,
	[Token(Token = "0x401A285")]
	ErrorCode_PluginAllocationFailed,
	[Token(Token = "0x401A286")]
	ErrorCode_VorbisRequireSeekTable,
	[Token(Token = "0x401A287")]
	ErrorCode_VorbisDecodeError,
	[Token(Token = "0x401A288")]
	ErrorCode_AACDecodeError,
	[Token(Token = "0x401A289")]
	ErrorCode_xWMACreateDecoderFailed,
	[Token(Token = "0x401A28A")]
	ErrorCode_ATRAC9CreateDecoderFailed,
	[Token(Token = "0x401A28B")]
	ErrorCode_ATRAC9CreateDecoderFailedChShortage,
	[Token(Token = "0x401A28C")]
	ErrorCode_ATRAC9DecodeFailed,
	[Token(Token = "0x401A28D")]
	ErrorCode_ATRAC9ClearContextFailed,
	[Token(Token = "0x401A28E")]
	ErrorCode_ATRAC9LoopSectionTooSmall,
	[Token(Token = "0x401A28F")]
	ErrorCode_InvalidAudioFileHeader,
	[Token(Token = "0x401A290")]
	ErrorCode_AudioFileHeaderTooLarge,
	[Token(Token = "0x401A291")]
	ErrorCode_FileTooSmall,
	[Token(Token = "0x401A292")]
	ErrorCode_TransitionNotAccurateChannel,
	[Token(Token = "0x401A293")]
	ErrorCode_TransitionNotAccurateStarvation,
	[Token(Token = "0x401A294")]
	ErrorCode_NothingToPlay,
	[Token(Token = "0x401A295")]
	ErrorCode_PlayFailed,
	[Token(Token = "0x401A296")]
	ErrorCode_StingerCouldNotBeScheduled,
	[Token(Token = "0x401A297")]
	ErrorCode_TooLongSegmentLookAhead,
	[Token(Token = "0x401A298")]
	ErrorCode_CannotScheduleMusicSwitch,
	[Token(Token = "0x401A299")]
	ErrorCode_TooManySimultaneousMusicSegments,
	[Token(Token = "0x401A29A")]
	ErrorCode_PlaylistStoppedForEditing,
	[Token(Token = "0x401A29B")]
	ErrorCode_MusicClipsRescheduledAfterTrackEdit,
	[Token(Token = "0x401A29C")]
	ErrorCode_CannotPlaySource_Create,
	[Token(Token = "0x401A29D")]
	ErrorCode_CannotPlaySource_VirtualOff,
	[Token(Token = "0x401A29E")]
	ErrorCode_CannotPlaySource_TimeSkip,
	[Token(Token = "0x401A29F")]
	ErrorCode_CannotPlaySource_InconsistentState,
	[Token(Token = "0x401A2A0")]
	ErrorCode_MediaNotLoaded,
	[Token(Token = "0x401A2A1")]
	ErrorCode_VoiceStarving,
	[Token(Token = "0x401A2A2")]
	ErrorCode_StreamingSourceStarving,
	[Token(Token = "0x401A2A3")]
	ErrorCode_XMADecoderSourceStarving,
	[Token(Token = "0x401A2A4")]
	ErrorCode_XMADecodingError,
	[Token(Token = "0x401A2A5")]
	ErrorCode_InvalidXMAData,
	[Token(Token = "0x401A2A6")]
	ErrorCode_PluginNotRegistered,
	[Token(Token = "0x401A2A7")]
	ErrorCode_CodecNotRegistered,
	[Token(Token = "0x401A2A8")]
	ErrorCode_PluginVersionMismatch,
	[Token(Token = "0x401A2A9")]
	ErrorCode_EventIDNotFound,
	[Token(Token = "0x401A2AA")]
	ErrorCode_InvalidGroupID,
	[Token(Token = "0x401A2AB")]
	ErrorCode_SelectedChildNotAvailable,
	[Token(Token = "0x401A2AC")]
	ErrorCode_SelectedNodeNotAvailable,
	[Token(Token = "0x401A2AD")]
	ErrorCode_SelectedMediaNotAvailable,
	[Token(Token = "0x401A2AE")]
	ErrorCode_NoValidSwitch,
	[Token(Token = "0x401A2AF")]
	ErrorCode_SelectedNodeNotAvailablePlay,
	[Token(Token = "0x401A2B0")]
	ErrorCode_FeedbackVoiceStarving,
	[Token(Token = "0x401A2B1")]
	ErrorCode_BankLoadFailed,
	[Token(Token = "0x401A2B2")]
	ErrorCode_BankUnloadFailed,
	[Token(Token = "0x401A2B3")]
	ErrorCode_ErrorWhileLoadingBank,
	[Token(Token = "0x401A2B4")]
	ErrorCode_InsufficientSpaceToLoadBank,
	[Token(Token = "0x401A2B5")]
	ErrorCode_LowerEngineCommandListFull,
	[Token(Token = "0x401A2B6")]
	ErrorCode_SeekNoMarker,
	[Token(Token = "0x401A2B7")]
	ErrorCode_CannotSeekContinuous,
	[Token(Token = "0x401A2B8")]
	ErrorCode_SeekAfterEof,
	[Token(Token = "0x401A2B9")]
	ErrorCode_UnknownGameObject,
	[Token(Token = "0x401A2BA")]
	ErrorCode_UnknownEmitter,
	[Token(Token = "0x401A2BB")]
	ErrorCode_UnknownListener,
	[Token(Token = "0x401A2BC")]
	ErrorCode_GameObjectIsNotListener,
	[Token(Token = "0x401A2BD")]
	ErrorCode_GameObjectIsNotEmitter,
	[Token(Token = "0x401A2BE")]
	ErrorCode_UnknownGameObjectEvent,
	[Token(Token = "0x401A2BF")]
	ErrorCode_GameObjectIsNotEmitterEvent,
	[Token(Token = "0x401A2C0")]
	ErrorCode_ExternalSourceNotResolved,
	[Token(Token = "0x401A2C1")]
	ErrorCode_FileFormatMismatch,
	[Token(Token = "0x401A2C2")]
	ErrorCode_CommandQueueFull,
	[Token(Token = "0x401A2C3")]
	ErrorCode_CommandTooLarge,
	[Token(Token = "0x401A2C4")]
	ErrorCode_XMACreateDecoderLimitReached,
	[Token(Token = "0x401A2C5")]
	ErrorCode_XMAStreamBufferTooSmall,
	[Token(Token = "0x401A2C6")]
	ErrorCode_ModulatorScopeError_Inst,
	[Token(Token = "0x401A2C7")]
	ErrorCode_ModulatorScopeError_Obj,
	[Token(Token = "0x401A2C8")]
	ErrorCode_SeekAfterEndOfPlaylist,
	[Token(Token = "0x401A2C9")]
	ErrorCode_OpusRequireSeekTable,
	[Token(Token = "0x401A2CA")]
	ErrorCode_OpusDecodeError,
	[Token(Token = "0x401A2CB")]
	ErrorCode_OpusCreateDecoderFailed,
	[Token(Token = "0x401A2CC")]
	ErrorCode_SourcePluginNotFound,
	[Token(Token = "0x401A2CD")]
	ErrorCode_VirtualVoiceLimit,
	[Token(Token = "0x401A2CE")]
	ErrorCode_AudioDeviceShareSetNotFound,
	[Token(Token = "0x401A2CF")]
	ErrorCode_NotEnoughMemoryToStart,
	[Token(Token = "0x401A2D0")]
	ErrorCode_UnkownOpusError,
	[Token(Token = "0x401A2D1")]
	ErrorCode_AudioDeviceInitFailure,
	[Token(Token = "0x401A2D2")]
	ErrorCode_AudioDeviceRemoveFailure,
	[Token(Token = "0x401A2D3")]
	ErrorCode_AudioDeviceNotFound,
	[Token(Token = "0x401A2D4")]
	ErrorCode_AudioDeviceNotValid,
	[Token(Token = "0x401A2D5")]
	ErrorCode_AudioDeviceOverproduction,
	[Token(Token = "0x401A2D6")]
	ErrorCode_MediaDuplicationLength,
	[Token(Token = "0x401A2D7")]
	Num_ErrorCodes
}
