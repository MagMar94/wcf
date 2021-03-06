// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ServiceModel.Diagnostics
{
    internal static class TraceCode
    {
        // Administration trace codes
        public const int Administration = 0X10000;
        public const int WmiPut = TraceCode.Administration | 0X0001;

        // Diagnostic trace codes
        public const int Diagnostics = 0X20000;
        public const int AppDomainUnload = TraceCode.Diagnostics | 0X0001;
        public const int EventLog = TraceCode.Diagnostics | 0X0002;
        public const int ThrowingException = TraceCode.Diagnostics | 0X0003;
        public const int TraceHandledException = TraceCode.Diagnostics | 0X0004;
        public const int UnhandledException = TraceCode.Diagnostics | 0X0005;
        public const int FailedToAddAnActivityIdHeader = TraceCode.Diagnostics | 0X0006;
        public const int FailedToReadAnActivityIdHeader = TraceCode.Diagnostics | 0X0007;
        public const int FilterNotMatchedNodeQuotaExceeded = TraceCode.Diagnostics | 0X0008;
        public const int MessageCountLimitExceeded = TraceCode.Diagnostics | 0X0009;
        public const int DiagnosticsFailedMessageTrace = TraceCode.Diagnostics | 0X000A;
        public const int MessageNotLoggedQuotaExceeded = TraceCode.Diagnostics | 0X000B;
        public const int TraceTruncatedQuotaExceeded = TraceCode.Diagnostics | 0X000C;
        public const int ActivityBoundary = TraceCode.Diagnostics | 0X000D;

        // Serialization trace codes (most live in System.Runtime.Serialization.dll)
        public const int Serialization = 0X30000;
        public const int ElementIgnored = TraceCode.Serialization | 0X0007; // shared by ServiceModel, need to investigate if should put this one in the SM section

        // Channels trace codes
        public const int Channels = 0X40000;
        public const int ConnectionAbandoned = TraceCode.Channels | 0X0001;
        public const int ConnectionPoolCloseException = TraceCode.Channels | 0X0002;
        public const int ConnectionPoolIdleTimeoutReached = TraceCode.Channels | 0X0003;
        public const int ConnectionPoolLeaseTimeoutReached = TraceCode.Channels | 0X0004;
        public const int ConnectionPoolMaxOutboundConnectionsPerEndpointQuotaReached = TraceCode.Channels | 0X0005;
        public const int ServerMaxPooledConnectionsQuotaReached = TraceCode.Channels | 0X0006;
        public const int EndpointListenerClose = TraceCode.Channels | 0X0007;
        public const int EndpointListenerOpen = TraceCode.Channels | 0X0008;
        public const int HttpResponseReceived = TraceCode.Channels | 0X0009;
        public const int HttpChannelConcurrentReceiveQuotaReached = TraceCode.Channels | 0X000A;
        public const int HttpChannelMessageReceiveFailed = TraceCode.Channels | 0X000B;
        public const int HttpChannelUnexpectedResponse = TraceCode.Channels | 0X000C;
        public const int HttpChannelRequestAborted = TraceCode.Channels | 0X000D;
        public const int HttpChannelResponseAborted = TraceCode.Channels | 0X000E;
        public const int HttpsClientCertificateInvalid = TraceCode.Channels | 0X000F;
        public const int HttpsClientCertificateNotPresent = TraceCode.Channels | 0X0010;
        public const int NamedPipeChannelMessageReceiveFailed = TraceCode.Channels | 0X0011;
        public const int NamedPipeChannelMessageReceived = TraceCode.Channels | 0X0012;
        public const int MessageReceived = TraceCode.Channels | 0X0013;
        public const int MessageSent = TraceCode.Channels | 0X0014;
        public const int RequestChannelReplyReceived = TraceCode.Channels | 0X0015;
        public const int TcpChannelMessageReceiveFailed = TraceCode.Channels | 0X0016;
        public const int TcpChannelMessageReceived = TraceCode.Channels | 0X0017;
        public const int ConnectToIPEndpoint = TraceCode.Channels | 0X0018;
        public const int SocketConnectionCreate = TraceCode.Channels | 0X0019;
        public const int SocketConnectionClose = TraceCode.Channels | 0X001A;
        public const int SocketConnectionAbort = TraceCode.Channels | 0X001B;
        public const int SocketConnectionAbortClose = TraceCode.Channels | 0X001C;
        public const int PipeConnectionAbort = TraceCode.Channels | 0X001D;
        public const int RequestContextAbort = TraceCode.Channels | 0X001E;
        public const int ChannelCreated = TraceCode.Channels | 0X001F;
        public const int ChannelDisposed = TraceCode.Channels | 0X0020;
        public const int ListenerCreated = TraceCode.Channels | 0X0021;
        public const int ListenerDisposed = TraceCode.Channels | 0X0022;
        public const int PrematureDatagramEof = TraceCode.Channels | 0X0023;
        public const int MaxPendingConnectionsReached = TraceCode.Channels | 0X0024;
        public const int MaxAcceptedChannelsReached = TraceCode.Channels | 0X0025;
        public const int ChannelConnectionDropped = TraceCode.Channels | 0X0026;
        public const int HttpAuthFailed = TraceCode.Channels | 0X0027;
        public const int NoExistingTransportManager = TraceCode.Channels | 0X0028;
        public const int IncompatibleExistingTransportManager = TraceCode.Channels | 0X0029;
        public const int InitiatingNamedPipeConnection = TraceCode.Channels | 0X002A;
        public const int InitiatingTcpConnection = TraceCode.Channels | 0X002B;
        public const int OpenedListener = TraceCode.Channels | 0X002C;
        public const int SslClientCertMissing = TraceCode.Channels | 0X002D;
        public const int StreamSecurityUpgradeAccepted = TraceCode.Channels | 0X002E;
        public const int TcpConnectError = TraceCode.Channels | 0X002F;
        public const int FailedAcceptFromPool = TraceCode.Channels | 0X0030;
        public const int FailedPipeConnect = TraceCode.Channels | 0X0031;
        public const int SystemTimeResolution = TraceCode.Channels | 0X0032;
        public const int PeerNeighborCloseFailed = TraceCode.Channels | 0X0033;
        public const int PeerNeighborClosingFailed = TraceCode.Channels | 0X0034;
        public const int PeerNeighborNotAccepted = TraceCode.Channels | 0X0035;
        public const int PeerNeighborNotFound = TraceCode.Channels | 0X0036;
        public const int PeerNeighborOpenFailed = TraceCode.Channels | 0X0037;
        public const int PeerNeighborStateChanged = TraceCode.Channels | 0X0038;
        public const int PeerNeighborStateChangeFailed = TraceCode.Channels | 0X0039;
        public const int PeerNeighborMessageReceived = TraceCode.Channels | 0X003A;
        public const int PeerNeighborManagerOffline = TraceCode.Channels | 0X003B;
        public const int PeerNeighborManagerOnline = TraceCode.Channels | 0X003C;
        public const int PeerChannelMessageReceived = TraceCode.Channels | 0X003D;
        public const int PeerChannelMessageSent = TraceCode.Channels | 0X003E;
        public const int PeerNodeAddressChanged = TraceCode.Channels | 0X003F;
        public const int PeerNodeOpening = TraceCode.Channels | 0X0040;
        public const int PeerNodeOpened = TraceCode.Channels | 0X0041;
        public const int PeerNodeOpenFailed = TraceCode.Channels | 0X0042;
        public const int PeerNodeClosing = TraceCode.Channels | 0X0043;
        public const int PeerNodeClosed = TraceCode.Channels | 0X0044;
        public const int PeerFloodedMessageReceived = TraceCode.Channels | 0X0045;
        public const int PeerFloodedMessageNotPropagated = TraceCode.Channels | 0X0046;
        public const int PeerFloodedMessageNotMatched = TraceCode.Channels | 0X0047;
        public const int PnrpRegisteredAddresses = TraceCode.Channels | 0X0048;
        public const int PnrpUnregisteredAddresses = TraceCode.Channels | 0X0049;
        public const int PnrpResolvedAddresses = TraceCode.Channels | 0X004A;
        public const int PnrpResolveException = TraceCode.Channels | 0X004B;
        public const int PeerReceiveMessageAuthenticationFailure = TraceCode.Channels | 0X004C;
        public const int PeerNodeAuthenticationFailure = TraceCode.Channels | 0X004D;
        public const int PeerNodeAuthenticationTimeout = TraceCode.Channels | 0X004E;
        public const int PeerFlooderReceiveMessageQuotaExceeded = TraceCode.Channels | 0X004F;
        public const int PeerServiceOpened = TraceCode.Channels | 0X0050;
        public const int PeerMaintainerActivity = TraceCode.Channels | 0X0051;
        public const int WsrmNegativeElapsedTimeDetected = TraceCode.Channels | 0X006E;
        public const int TcpTransferError = TraceCode.Channels | 0X006F;
        public const int TcpConnectionResetError = TraceCode.Channels | 0X0070;
        public const int TcpConnectionTimedOut = TraceCode.Channels | 0X0071;

        // ComIntegration trace codes
        public const int ComIntegration = 0X50000;
        public const int ComIntegrationServiceHostStartingService = TraceCode.ComIntegration | 0X0001;
        public const int ComIntegrationServiceHostStartedService = TraceCode.ComIntegration | 0X0002;
        public const int ComIntegrationServiceHostCreatedServiceContract = TraceCode.ComIntegration | 0X0003;
        public const int ComIntegrationServiceHostStartedServiceDetails = TraceCode.ComIntegration | 0X0004;
        public const int ComIntegrationServiceHostCreatedServiceEndpoint = TraceCode.ComIntegration | 0X0005;
        public const int ComIntegrationServiceHostStoppingService = TraceCode.ComIntegration | 0X0006;
        public const int ComIntegrationServiceHostStoppedService = TraceCode.ComIntegration | 0X0007;
        public const int ComIntegrationDllHostInitializerStarting = TraceCode.ComIntegration | 0X0008;
        public const int ComIntegrationDllHostInitializerAddingHost = TraceCode.ComIntegration | 0X0009;
        public const int ComIntegrationDllHostInitializerStarted = TraceCode.ComIntegration | 0X000A;
        public const int ComIntegrationDllHostInitializerStopping = TraceCode.ComIntegration | 0X000B;
        public const int ComIntegrationDllHostInitializerStopped = TraceCode.ComIntegration | 0X000C;
        public const int ComIntegrationTLBImportStarting = TraceCode.ComIntegration | 0X000D;
        public const int ComIntegrationTLBImportFromAssembly = TraceCode.ComIntegration | 0X000E;
        public const int ComIntegrationTLBImportFromTypelib = TraceCode.ComIntegration | 0X000F;
        public const int ComIntegrationTLBImportConverterEvent = TraceCode.ComIntegration | 0X0010;
        public const int ComIntegrationTLBImportFinished = TraceCode.ComIntegration | 0X0011;
        public const int ComIntegrationInstanceCreationRequest = TraceCode.ComIntegration | 0X0012;
        public const int ComIntegrationInstanceCreationSuccess = TraceCode.ComIntegration | 0X0013;
        public const int ComIntegrationInstanceReleased = TraceCode.ComIntegration | 0X0014;
        public const int ComIntegrationEnteringActivity = TraceCode.ComIntegration | 0X0015;
        public const int ComIntegrationExecutingCall = TraceCode.ComIntegration | 0X0016;
        public const int ComIntegrationLeftActivity = TraceCode.ComIntegration | 0X0017;
        public const int ComIntegrationInvokingMethod = TraceCode.ComIntegration | 0X0018;
        public const int ComIntegrationInvokedMethod = TraceCode.ComIntegration | 0X0019;
        public const int ComIntegrationInvokingMethodNewTransaction = TraceCode.ComIntegration | 0X001A;
        public const int ComIntegrationInvokingMethodContextTransaction = TraceCode.ComIntegration | 0X001B;
        public const int ComIntegrationServiceMonikerParsed = TraceCode.ComIntegration | 0X001C;
        public const int ComIntegrationWsdlChannelBuilderLoaded = TraceCode.ComIntegration | 0X001D;
        public const int ComIntegrationTypedChannelBuilderLoaded = TraceCode.ComIntegration | 0X001E;
        public const int ComIntegrationChannelCreated = TraceCode.ComIntegration | 0X001F;
        public const int ComIntegrationDispatchMethod = TraceCode.ComIntegration | 0X0020;
        public const int ComIntegrationTxProxyTxCommitted = TraceCode.ComIntegration | 0X0021;
        public const int ComIntegrationTxProxyTxAbortedByContext = TraceCode.ComIntegration | 0X0022;
        public const int ComIntegrationTxProxyTxAbortedByTM = TraceCode.ComIntegration | 0X0023;
        public const int ComIntegrationMexMonikerMetadataExchangeComplete = TraceCode.ComIntegration | 0X0024;
        public const int ComIntegrationMexChannelBuilderLoaded = TraceCode.ComIntegration | 0X0025;

        // Security trace codes
        public const int Security = 0X70000;
        public const int SecurityIdentityVerificationSuccess = TraceCode.Security | 0X0001;
        public const int SecurityIdentityVerificationFailure = TraceCode.Security | 0X0002;
        public const int SecurityIdentityDeterminationSuccess = TraceCode.Security | 0X0003;
        public const int SecurityIdentityDeterminationFailure = TraceCode.Security | 0X0004;
        public const int SecurityIdentityHostNameNormalizationFailure = TraceCode.Security | 0X0005;
        public const int SecurityImpersonationSuccess = TraceCode.Security | 0X0006;
        public const int SecurityImpersonationFailure = TraceCode.Security | 0X0007;
        public const int SecurityNegotiationProcessingFailure = TraceCode.Security | 0X0008;
        public const int IssuanceTokenProviderRemovedCachedToken = TraceCode.Security | 0X0009;
        public const int IssuanceTokenProviderUsingCachedToken = TraceCode.Security | 0X000A;
        public const int IssuanceTokenProviderBeginSecurityNegotiation = TraceCode.Security | 0X000B;
        public const int IssuanceTokenProviderEndSecurityNegotiation = TraceCode.Security | 0X000C;
        public const int IssuanceTokenProviderRedirectApplied = TraceCode.Security | 0X000D;
        public const int IssuanceTokenProviderServiceTokenCacheFull = TraceCode.Security | 0X000E;
        public const int NegotiationTokenProviderAttached = TraceCode.Security | 0X000F;
        public const int SpnegoClientNegotiationCompleted = TraceCode.Security | 0X0020;
        public const int SpnegoServiceNegotiationCompleted = TraceCode.Security | 0X0021;
        public const int SpnegoClientNegotiation = TraceCode.Security | 0X0022;
        public const int SpnegoServiceNegotiation = TraceCode.Security | 0X0023;
        public const int NegotiationAuthenticatorAttached = TraceCode.Security | 0X0024;
        public const int ServiceSecurityNegotiationCompleted = TraceCode.Security | 0X0025;
        public const int SecurityContextTokenCacheFull = TraceCode.Security | 0X0026;
        public const int ExportSecurityChannelBindingEntry = TraceCode.Security | 0X0027;
        public const int ExportSecurityChannelBindingExit = TraceCode.Security | 0X0028;
        public const int ImportSecurityChannelBindingEntry = TraceCode.Security | 0X0029;
        public const int ImportSecurityChannelBindingExit = TraceCode.Security | 0X002A;
        public const int SecurityTokenProviderOpened = TraceCode.Security | 0X002B;
        public const int SecurityTokenProviderClosed = TraceCode.Security | 0X002C;
        public const int SecurityTokenAuthenticatorOpened = TraceCode.Security | 0X002D;
        public const int SecurityTokenAuthenticatorClosed = TraceCode.Security | 0X002E;
        public const int SecurityBindingOutgoingMessageSecured = TraceCode.Security | 0X002F;
        public const int SecurityBindingIncomingMessageVerified = TraceCode.Security | 0X0030;
        public const int SecurityBindingSecureOutgoingMessageFailure = TraceCode.Security | 0X0031;
        public const int SecurityBindingVerifyIncomingMessageFailure = TraceCode.Security | 0X0032;
        public const int SecuritySpnToSidMappingFailure = TraceCode.Security | 0X0033;
        public const int SecuritySessionRedirectApplied = TraceCode.Security | 0X0034;
        public const int SecurityClientSessionCloseSent = TraceCode.Security | 0X0035;
        public const int SecurityClientSessionCloseResponseSent = TraceCode.Security | 0X0036;
        public const int SecurityClientSessionCloseMessageReceived = TraceCode.Security | 0X0037;
        public const int SecuritySessionKeyRenewalFaultReceived = TraceCode.Security | 0X0038;
        public const int SecuritySessionAbortedFaultReceived = TraceCode.Security | 0X0039;
        public const int SecuritySessionClosedResponseReceived = TraceCode.Security | 0X003A;
        public const int SecurityClientSessionPreviousKeyDiscarded = TraceCode.Security | 0X003B;
        public const int SecurityClientSessionKeyRenewed = TraceCode.Security | 0X003C;
        public const int SecurityPendingServerSessionAdded = TraceCode.Security | 0X003D;
        public const int SecurityPendingServerSessionClosed = TraceCode.Security | 0X003E;
        public const int SecurityPendingServerSessionActivated = TraceCode.Security | 0X003F;
        public const int SecurityActiveServerSessionRemoved = TraceCode.Security | 0X0040;
        public const int SecurityNewServerSessionKeyIssued = TraceCode.Security | 0X0041;
        public const int SecurityInactiveSessionFaulted = TraceCode.Security | 0X0042;
        public const int SecurityServerSessionKeyUpdated = TraceCode.Security | 0X0043;
        public const int SecurityServerSessionCloseReceived = TraceCode.Security | 0X0044;
        public const int SecurityServerSessionRenewalFaultSent = TraceCode.Security | 0X0045;
        public const int SecurityServerSessionAbortedFaultSent = TraceCode.Security | 0X0046;
        public const int SecuritySessionCloseResponseSent = TraceCode.Security | 0X0047;
        public const int SecuritySessionServerCloseSent = TraceCode.Security | 0X0048;
        public const int SecurityServerSessionCloseResponseReceived = TraceCode.Security | 0X0049;
        public const int SecuritySessionRenewFaultSendFailure = TraceCode.Security | 0X004A;
        public const int SecuritySessionAbortedFaultSendFailure = TraceCode.Security | 0X004B;
        public const int SecuritySessionClosedResponseSendFailure = TraceCode.Security | 0X004C;
        public const int SecuritySessionServerCloseSendFailure = TraceCode.Security | 0X004D;
        public const int SecuritySessionRequestorStartOperation = TraceCode.Security | 0X004E;
        public const int SecuritySessionRequestorOperationSuccess = TraceCode.Security | 0X004F;
        public const int SecuritySessionRequestorOperationFailure = TraceCode.Security | 0X0050;
        public const int SecuritySessionResponderOperationFailure = TraceCode.Security | 0X0051;
        public const int SecuritySessionDemuxFailure = TraceCode.Security | 0X0052;
        public const int SecurityAuditWrittenSuccess = TraceCode.Security | 0X0053;
        public const int SecurityAuditWrittenFailure = TraceCode.Security | 0X0054;

        // ServiceModel trace codes
        public const int ServiceModel = 0X80000;
        public const int AsyncCallbackThrewException = TraceCode.ServiceModel | 0X0001;
        public const int CommunicationObjectAborted = TraceCode.ServiceModel | 0X0002;
        public const int CommunicationObjectAbortFailed = TraceCode.ServiceModel | 0X0003;
        public const int CommunicationObjectCloseFailed = TraceCode.ServiceModel | 0X0004;
        public const int CommunicationObjectOpenFailed = TraceCode.ServiceModel | 0X0005;
        public const int CommunicationObjectClosing = TraceCode.ServiceModel | 0X0006;
        public const int CommunicationObjectClosed = TraceCode.ServiceModel | 0X0007;
        public const int CommunicationObjectCreated = TraceCode.ServiceModel | 0X0008;
        public const int CommunicationObjectDisposing = TraceCode.ServiceModel | 0X0009;
        public const int CommunicationObjectFaultReason = TraceCode.ServiceModel | 0X000A;
        public const int CommunicationObjectFaulted = TraceCode.ServiceModel | 0X000B;
        public const int CommunicationObjectOpening = TraceCode.ServiceModel | 0X000C;
        public const int CommunicationObjectOpened = TraceCode.ServiceModel | 0X000D;
        public const int DidNotUnderstandMessageHeader = TraceCode.ServiceModel | 0X000E;
        public const int UnderstoodMessageHeader = TraceCode.ServiceModel | 0X000F;
        public const int MessageClosed = TraceCode.ServiceModel | 0X0010;
        public const int MessageClosedAgain = TraceCode.ServiceModel | 0X0011;
        public const int MessageCopied = TraceCode.ServiceModel | 0X0012;
        public const int MessageRead = TraceCode.ServiceModel | 0X0013;
        public const int MessageWritten = TraceCode.ServiceModel | 0X0014;
        public const int BeginExecuteMethod = TraceCode.ServiceModel | 0X0015;
        public const int ConfigurationIsReadOnly = TraceCode.ServiceModel | 0X0016;
        public const int ConfiguredExtensionTypeNotFound = TraceCode.ServiceModel | 0X0017;
        public const int EvaluationContextNotFound = TraceCode.ServiceModel | 0X0018;
        public const int EndExecuteMethod = TraceCode.ServiceModel | 0X0019;
        public const int ExtensionCollectionDoesNotExist = TraceCode.ServiceModel | 0X001A;
        public const int ExtensionCollectionNameNotFound = TraceCode.ServiceModel | 0X001B;
        public const int ExtensionCollectionIsEmpty = TraceCode.ServiceModel | 0X001C;
        public const int ExtensionElementAlreadyExistsInCollection = TraceCode.ServiceModel | 0X001D;
        public const int ElementTypeDoesntMatchConfiguredType = TraceCode.ServiceModel | 0X001E;
        public const int ErrorInvokingUserCode = TraceCode.ServiceModel | 0X001F;
        public const int GetBehaviorElement = TraceCode.ServiceModel | 0X0020;
        public const int GetCommonBehaviors = TraceCode.ServiceModel | 0X0021;
        public const int GetConfiguredBinding = TraceCode.ServiceModel | 0X0022;
        public const int GetChannelEndpointElement = TraceCode.ServiceModel | 0X0023;
        public const int GetConfigurationSection = TraceCode.ServiceModel | 0X0024;
        public const int GetDefaultConfiguredBinding = TraceCode.ServiceModel | 0X0025;
        public const int GetServiceElement = TraceCode.ServiceModel | 0X0026;
        public const int MessageProcessingPaused = TraceCode.ServiceModel | 0X0027;
        public const int ManualFlowThrottleLimitReached = TraceCode.ServiceModel | 0X0028;
        public const int OverridingDuplicateConfigurationKey = TraceCode.ServiceModel | 0X0029;
        public const int RemoveBehavior = TraceCode.ServiceModel | 0X002A;
        public const int ServiceChannelLifetime = TraceCode.ServiceModel | 0X002B;
        public const int ServiceHostCreation = TraceCode.ServiceModel | 0X002C;
        public const int ServiceHostBaseAddresses = TraceCode.ServiceModel | 0X002D;
        public const int ServiceHostTimeoutOnClose = TraceCode.ServiceModel | 0X002E;
        public const int ServiceHostFaulted = TraceCode.ServiceModel | 0X002F;
        public const int ServiceHostErrorOnReleasePerformanceCounter = TraceCode.ServiceModel | 0X0030;
        public const int ServiceThrottleLimitReached = TraceCode.ServiceModel | 0X0031;
        public const int ServiceOperationMissingReply = TraceCode.ServiceModel | 0X0032;
        public const int ServiceOperationMissingReplyContext = TraceCode.ServiceModel | 0X0033;
        public const int ServiceOperationExceptionOnReply = TraceCode.ServiceModel | 0X0034;
        public const int SkipBehavior = TraceCode.ServiceModel | 0X0035;
        public const int TransportListen = TraceCode.ServiceModel | 0X0036;
        public const int UnhandledAction = TraceCode.ServiceModel | 0X0037;
        public const int PerformanceCounterFailedToLoad = TraceCode.ServiceModel | 0X0038;
        public const int PerformanceCountersFailed = TraceCode.ServiceModel | 0X0039;
        public const int PerformanceCountersFailedDuringUpdate = TraceCode.ServiceModel | 0X003A;
        public const int PerformanceCountersFailedForService = TraceCode.ServiceModel | 0X003B;
        public const int PerformanceCountersFailedOnRelease = TraceCode.ServiceModel | 0X003C;
        public const int WsmexNonCriticalWsdlExportError = TraceCode.ServiceModel | 0X003D;
        public const int WsmexNonCriticalWsdlImportError = TraceCode.ServiceModel | 0X003E;
        public const int FailedToOpenIncomingChannel = TraceCode.ServiceModel | 0X003F;
        public const int UnhandledExceptionInUserOperation = TraceCode.ServiceModel | 0X0040;
        public const int DroppedAMessage = TraceCode.ServiceModel | 0X0041;
        public const int CannotBeImportedInCurrentFormat = TraceCode.ServiceModel | 0X0042;
        public const int GetConfiguredEndpoint = TraceCode.ServiceModel | 0X0043;
        public const int GetDefaultConfiguredEndpoint = TraceCode.ServiceModel | 0X0044;
        public const int ExtensionTypeNotFound = TraceCode.ServiceModel | 0X0045;
        public const int DefaultEndpointsAdded = TraceCode.ServiceModel | 0X0046;

        //ServiceModel Metadata codes
        public const int MetadataExchangeClientSendRequest = TraceCode.ServiceModel | 0X005B;
        public const int MetadataExchangeClientReceiveReply = TraceCode.ServiceModel | 0X005C;
        public const int WarnHelpPageEnabledNoBaseAddress = TraceCode.ServiceModel | 0X005D;

        // PortSharingtrace codes
        public const int PortSharing = 0xA0000;
        public const int PortSharingClosed = TraceCode.PortSharing | 0X0001;
        public const int PortSharingDuplicatedPipe = TraceCode.PortSharing | 0X0002;
        public const int PortSharingDupHandleGranted = TraceCode.PortSharing | 0X0003;
        public const int PortSharingDuplicatedSocket = TraceCode.PortSharing | 0X0004;
        public const int PortSharingListening = TraceCode.PortSharing | 0X0005;

        public const int SharedManagerServiceEndpointNotExist = TraceCode.PortSharing | 0X000E;

        //Indigo Tx trace codes
        public const int ServiceModelTransaction = 0xE0000;
        public const int TxSourceTxScopeRequiredIsTransactedTransport = TraceCode.ServiceModelTransaction | 0X0001;
        public const int TxSourceTxScopeRequiredIsTransactionFlow = TraceCode.ServiceModelTransaction | 0X0002;
        public const int TxSourceTxScopeRequiredIsAttachedTransaction = TraceCode.ServiceModelTransaction | 0X0003;
        public const int TxSourceTxScopeRequiredIsCreateNewTransaction = TraceCode.ServiceModelTransaction | 0X0004;
        public const int TxCompletionStatusCompletedForAutocomplete = TraceCode.ServiceModelTransaction | 0X0005;
        public const int TxCompletionStatusCompletedForError = TraceCode.ServiceModelTransaction | 0X0006;
        public const int TxCompletionStatusCompletedForSetComplete = TraceCode.ServiceModelTransaction | 0X0007;
        public const int TxCompletionStatusCompletedForTACOSC = TraceCode.ServiceModelTransaction | 0X0008;
        public const int TxCompletionStatusCompletedForAsyncAbort = TraceCode.ServiceModelTransaction | 0X0009;
        public const int TxCompletionStatusRemainsAttached = TraceCode.ServiceModelTransaction | 0X000A;
        public const int TxCompletionStatusAbortedOnSessionClose = TraceCode.ServiceModelTransaction | 0X000B;
        public const int TxReleaseServiceInstanceOnCompletion = TraceCode.ServiceModelTransaction | 0X000C;
        public const int TxAsyncAbort = TraceCode.ServiceModelTransaction | 0X000D;
        public const int TxFailedToNegotiateOleTx = TraceCode.ServiceModelTransaction | 0X000E;
        public const int TxSourceTxScopeRequiredUsingExistingTransaction = TraceCode.ServiceModelTransaction | 0X000F;

        //CfxGreen trace codes
        public const int NetFx35 = 0xF0000;
        public const int ActivatingMessageReceived = TraceCode.NetFx35 | 0X0000; // NetFx35 overloaded category and ActivatingMessageReceived
        public const int InstanceContextBoundToDurableInstance = TraceCode.NetFx35 | 0X0001;
        public const int InstanceContextDetachedFromDurableInstance = TraceCode.NetFx35 | 0X0002;
        public const int ContextChannelFactoryChannelCreated = TraceCode.NetFx35 | 0X0003;
        public const int ContextChannelListenerChannelAccepted = TraceCode.NetFx35 | 0X0004;
        public const int ContextProtocolContextAddedToMessage = TraceCode.NetFx35 | 0X0005;
        public const int ContextProtocolContextRetrievedFromMessage = TraceCode.NetFx35 | 0X0006;
        public const int DICPInstanceContextCached = TraceCode.NetFx35 | 0X0007;
        public const int DICPInstanceContextRemovedFromCache = TraceCode.NetFx35 | 0X0008;
        public const int ServiceDurableInstanceDeleted = TraceCode.NetFx35 | 0X0009;
        public const int ServiceDurableInstanceDisposed = TraceCode.NetFx35 | 0X000A;
        public const int ServiceDurableInstanceLoaded = TraceCode.NetFx35 | 0X000B;
        public const int ServiceDurableInstanceSaved = TraceCode.NetFx35 | 0X000C;
        public const int SqlPersistenceProviderSQLCallStart = TraceCode.NetFx35 | 0X000D;
        public const int SqlPersistenceProviderSQLCallEnd = TraceCode.NetFx35 | 0X000E;
        public const int SqlPersistenceProviderOpenParameters = TraceCode.NetFx35 | 0X000F;
        public const int SyncContextSchedulerServiceTimerCancelled = TraceCode.NetFx35 | 0X0010;
        public const int SyncContextSchedulerServiceTimerCreated = TraceCode.NetFx35 | 0X0011;
        public const int WorkflowDurableInstanceLoaded = TraceCode.NetFx35 | 0X0012;
        public const int WorkflowDurableInstanceAborted = TraceCode.NetFx35 | 0X0013;
        public const int WorkflowDurableInstanceActivated = TraceCode.NetFx35 | 0X0014;
        public const int WorkflowOperationInvokerItemQueued = TraceCode.NetFx35 | 0X0015;
        public const int WorkflowRequestContextReplySent = TraceCode.NetFx35 | 0X0016;
        public const int WorkflowRequestContextFaultSent = TraceCode.NetFx35 | 0X0017;
        public const int WorkflowServiceHostCreated = TraceCode.NetFx35 | 0X0018;
        public const int SyndicationReadFeedBegin = TraceCode.NetFx35 | 0X0019;
        public const int SyndicationReadFeedEnd = TraceCode.NetFx35 | 0X001A;
        public const int SyndicationReadItemBegin = TraceCode.NetFx35 | 0X001B;
        public const int SyndicationReadItemEnd = TraceCode.NetFx35 | 0X001C;
        public const int SyndicationWriteFeedBegin = TraceCode.NetFx35 | 0X001D;
        public const int SyndicationWriteFeedEnd = TraceCode.NetFx35 | 0X001E;
        public const int SyndicationWriteItemBegin = TraceCode.NetFx35 | 0X001F;
        public const int SyndicationWriteItemEnd = TraceCode.NetFx35 | 0X0020;
        public const int SyndicationProtocolElementIgnoredOnRead = TraceCode.NetFx35 | 0X0021;
        public const int SyndicationProtocolElementIgnoredOnWrite = TraceCode.NetFx35 | 0X0022;
        public const int SyndicationProtocolElementInvalid = TraceCode.NetFx35 | 0X0023;
        public const int WebUnknownQueryParameterIgnored = TraceCode.NetFx35 | 0X0024;
        public const int WebRequestMatchesOperation = TraceCode.NetFx35 | 0X0025;
        public const int WebRequestDoesNotMatchOperations = TraceCode.NetFx35 | 0X0026;
        public const int WebRequestRedirect = TraceCode.NetFx35 | 0X0027;
        public const int SyndicationReadServiceDocumentBegin = TraceCode.NetFx35 | 0X0028;
        public const int SyndicationReadServiceDocumentEnd = TraceCode.NetFx35 | 0X0029;
        public const int SyndicationReadCategoriesDocumentBegin = TraceCode.NetFx35 | 0X002A;
        public const int SyndicationReadCategoriesDocumentEnd = TraceCode.NetFx35 | 0X002B;
        public const int SyndicationWriteServiceDocumentBegin = TraceCode.NetFx35 | 0X002C;
        public const int SyndicationWriteServiceDocumentEnd = TraceCode.NetFx35 | 0X002D;
        public const int SyndicationWriteCategoriesDocumentBegin = TraceCode.NetFx35 | 0X002E;
        public const int SyndicationWriteCategoriesDocumentEnd = TraceCode.NetFx35 | 0X002F;
        public const int AutomaticFormatSelectedOperationDefault = TraceCode.NetFx35 | 0X0030;
        public const int AutomaticFormatSelectedRequestBased = TraceCode.NetFx35 | 0X0031;
        public const int RequestFormatSelectedFromContentTypeMapper = TraceCode.NetFx35 | 0X0032;
        public const int RequestFormatSelectedByEncoderDefaults = TraceCode.NetFx35 | 0X0033;
        public const int AddingResponseToOutputCache = TraceCode.NetFx35 | 0X0034;
        public const int AddingAuthenticatedResponseToOutputCache = TraceCode.NetFx35 | 0X0035;
        public const int JsonpCallbackNameSet = TraceCode.NetFx35 | 0X0037;
    }
}
