import './PictureComp.css';
import picBicycle from '../assets/rower2.jpg';
const PictureComp = () => {
    return (
        <div className='picture'>
            <h5 style={{ textAlign: 'center' }}>Rower</h5>
            <div className='center'><img src={picBicycle} alt="rower" />
            </div>
        </div>
    )
}

export default PictureComp;