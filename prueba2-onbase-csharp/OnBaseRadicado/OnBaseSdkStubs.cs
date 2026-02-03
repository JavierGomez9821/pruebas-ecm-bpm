// OnBaseSdkStubs.cs
// Clases e interfaces simuladas para la prueba técnica.
// Este archivo NO corresponde al SDK real de Hyland OnBase, solo es un modelo simplificado.

using System;
using System.Collections.Generic;

namespace OnBase.Sdk.Simulado
{
    public interface IOnBaseApplication
    {
        IDocument GetDocument(int documentId);
        void LogInfo(string message);
        void LogError(string message, Exception ex);
    }

    public interface IDocument
    {
        int DocumentId { get; }
        string DocumentTypeName { get; }

        IReadOnlyCollection<IKeyword> Keywords { get; }

        /// <summary>
        /// Agrega un keyword al documento.
        /// </summary>
        void AddKeyword(string keywordTypeName, string value);
    }

    public interface IKeyword
    {
        string KeywordTypeName { get; }
        string Value { get; }
    }

    // Implementaciones muy simples para que el candidato pueda probar su lógica si lo desea.
    public class OnBaseApplicationSimulada : IOnBaseApplication
    {
        private readonly Dictionary<int, IDocument> _documentos = new();

        public OnBaseApplicationSimulada()
        {
            // Poblar con algunos documentos de prueba
            _documentos[1001] = new DocumentSimulado(1001, "Solicitud Crédito");
            _documentos[1002] = new DocumentSimulado(1002, "PQRS");
            _documentos[1003] = new DocumentSimulado(1003, "Reclamo");
        }

        public IDocument GetDocument(int documentId)
        {
            if (_documentos.TryGetValue(documentId, out var doc))
                return doc;

            throw new InvalidOperationException($"Documento con ID {documentId} no encontrado.");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"[INFO ] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }

        public void LogError(string message, Exception ex)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            Console.WriteLine($"        Detalle: {ex.Message}");
        }
    }

    public class DocumentSimulado : IDocument
    {
        private readonly List<IKeyword> _keywords = new();

        public DocumentSimulado(int documentId, string documentTypeName)
        {
            DocumentId = documentId;
            DocumentTypeName = documentTypeName;
        }

        public int DocumentId { get; }
        public string DocumentTypeName { get; }
        public IReadOnlyCollection<IKeyword> Keywords => _keywords.AsReadOnly();

        public void AddKeyword(string keywordTypeName, string value)
        {
            _keywords.Add(new KeywordSimulado(keywordTypeName, value));
        }
    }

    public class KeywordSimulado : IKeyword
    {
        public KeywordSimulado(string keywordTypeName, string value)
        {
            KeywordTypeName = keywordTypeName;
            Value = value;
        }

        public string KeywordTypeName { get; }
        public string Value { get; }
    }
}
