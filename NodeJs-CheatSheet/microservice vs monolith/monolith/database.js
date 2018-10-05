const databaseFunction = () => {
    const config = {};
    const data = [{title: 'title a', content: 'content what ever'}];

    if (config.hasData){
        return data;
    } else {
        process.exit(1);
    }
};

module.exports = {
    databaseFunction
};