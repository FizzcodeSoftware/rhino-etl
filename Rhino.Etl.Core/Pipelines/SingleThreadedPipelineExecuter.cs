namespace Rhino.Etl.Core.Pipelines
{
    using System.Collections.Generic;
    using Enumerables;
    using Operations;

    /// <summary>
    /// Executes the pipeline on a single thread
    /// </summary>
    public class SingleThreadedPipelineExecuter : AbstractPipelineExecuter
    {
        /// <summary>
        /// Add a decorator to the enumerable for additional processing
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <param name="enumerator">The enumerator.</param>
        protected override IEnumerable<Row> DecorateEnumerableForExecution(IOperation operation, IEnumerable<Row> enumerator)
        {
            return new CachingEnumerable<Row>(new EventRaisingEnumerator(operation, enumerator));
        }
    }
}